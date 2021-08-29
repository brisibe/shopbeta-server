using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopbeta.Core.DTO.Requests;
using shopbeta.Core.Interfaces;
using shopbeta.Core.Models;

namespace shopbeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;

        public OrderController(IRepositoryManager repository, IMapper mapper, ILoggerManager logger, UserManager<User> userManager)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var orders = await _repository.Order.GetAllOrdersAsync(trackChanges: false);

                return Ok(orders);

            }catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500, "something went wrong, internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderByUserId(Guid userId)
        {
            try
            {
                if (userId == null)
                {
                    _logger.Error("insert userId");
                    return BadRequest();
                }
                var order = await _repository.Order.GetOrdersById(userId, trackChanges: false);

                if(order == null)
                {
                    _logger.Info("there are no orders for this user"); 
                    return BadRequest();
                }

                return Ok(order);


            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500, "something went wrong, internal server error");
            }
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<IActionResult> CreatOrder([FromBody] OrderCreationDto orderDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return UnprocessableEntity();
                }

                var order = _mapper.Map<Order>(orderDto);

                _repository.Order.CancelOrder(order);
                await _repository.SaveAsync();

                return StatusCode(201);
                

            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500, "something went wrong, internal server error");
            }
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //[HttpPost("shipping")]
        //public Task<IActionResult> AddShippingAddress ([FromBody] ShippingAddress shippingAddress)
        //{
        //    ClaimsPrincipal user = this.User;

        //}
    }
}
