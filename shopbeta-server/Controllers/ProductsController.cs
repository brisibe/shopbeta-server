using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopbeta.Core.DTO.Requests;
using shopbeta.Core.DTO.Response;
using shopbeta.Core.Interfaces;
using shopbeta.Core.Models;

namespace shopbeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IStorageService _blobStorage;

        public ProductsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IStorageService blobStorage)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _blobStorage = blobStorage;

        }

        // GET: api/<ProductsController>
        [HttpGet]
        //[ResponseCache(Duration = 120)]
        public async Task<IActionResult> GetProducts() 
        {
            try
            {
                var products = await _repository.Product.GetAllProductsAsync(trackChanges: false);

                //var productsDto = _mapper.Map<ProductsResponseDto>(products);
                
                return Ok(products);

            }
            catch (Exception ex)
            {
                _logger.Error($"something went wrong in the {nameof(GetProducts)} action: {ex}");

                return StatusCode(500, "internal server error");
            }
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}", Name = "productById")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            try
            {
                var product = await _repository.Product.GetProductAsync(id, trackChanges: false);
                if (product == null)
                {
                    _logger.Info($"product with id {id} not in the database");

                    return NotFound();
                }

              var productsDto =  _mapper.Map<ProductsRequestDto>(product);

                return Ok(product);

            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500, "something went wrong, internal server error");
            }
        }

        // POST api/<ProductsController>
        [Authorize(Roles = " Seller ")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm] ProductsRequestDto productDto)
        {
            try
            {

                if (productDto == null)
                {
                    _logger.Error("product sent from client is empty");
                    return BadRequest("product object is empty");
                }
                if (!ModelState.IsValid)
                {
                    _logger.Error("invalid model state for product");
                    return UnprocessableEntity();
                }


                ClaimsPrincipal user = this.User;
                string sellerName = user.Claims.Where(c => c.Type == "Store")
                    .Select(x => x.Value).FirstOrDefault();

                var product = _mapper.Map<Product>(productDto);
                product.SellerName = sellerName;

                //var seller = user.IsInRole("Seller");
                
                if(productDto.photo != null)
                {
                     var imageUrl =  await _blobStorage.Upload(productDto.photo);

                     product.Photo = imageUrl;
                }

                _repository.Product.CreateProduct(product);
                await _repository.SaveAsync();

                var productResponse = _mapper.Map<ProductsResponseDto>(product);

                return CreatedAtRoute("productById", new { id = productResponse.productId }, productResponse);



            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500, "something went wrong, internal server error");
            }

        }



        // DELETE api/<ProductsController>/5
        [Authorize(Roles = "SELLER")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            try
            {
                var product = await _repository.Product.GetProductAsync(id, trackChanges: false);

                if(product == null)
                {
                    _logger.Error($"product with id {id} was not found.");
                    return NotFound();
                }

                _repository.Product.DeleteProduct(product);
                await _repository.SaveAsync();

                return StatusCode(204);

            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500, "something went wrong, internal server error");
            }
        }
    }
}
