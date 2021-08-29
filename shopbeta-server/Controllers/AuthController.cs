using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopbeta.Core.DTO;
using shopbeta.Core.Interfaces;
using shopbeta.Core.Models;

namespace shopbeta.Controllers
{    

    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IAuthenticationManager _authenticationManager;

        public AuthController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IAuthenticationManager authenticationManager)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _authenticationManager = authenticationManager ?? throw new ArgumentNullException(nameof(authenticationManager));
        }
        [HttpPost("register/buyer")]
        public async Task<IActionResult> BuyerRegistration ([FromBody] BuyerRegistration buyerRegistration)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return UnprocessableEntity();
                }

                var user = _mapper.Map<User>(buyerRegistration);

                var result = await _userManager.CreateAsync(user, buyerRegistration.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.TryAddModelError(error.Code, error.Description);
                    }
                    return StatusCode(400, result.Errors);
                }

                //var SellerRole = new List<string> {  "hello" };
                //await _userManager.AddToRoleAsync(user, "BUYER");

                return StatusCode(201);
            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpPost("register/seller")]
        public async Task<IActionResult> SellerRegisteration([FromBody] SellerRegistration sellerRegistration)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return UnprocessableEntity();
                }

                var user = _mapper.Map<User>(sellerRegistration);

                var result = await _userManager.CreateAsync(user, sellerRegistration.Password);

                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {    
                        ModelState.TryAddModelError(error.Code, error.Description);
                    }
                    return StatusCode(400, result.Errors);
                }

                //await _userManager.AddToRoleAsync(user, "SELLER");
                return StatusCode(201);

            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserAuthenticationDto userAuthentication)
        {
            try
            {
                var validateUser = await _authenticationManager.ValidateUser(userAuthentication);
                

                if (!validateUser)
                {
                    _logger.Warn($"{nameof(Login)}: Authentication failed. Wrong username or password.");

                    return StatusCode(401, new { message = "email or password is incorrect" });
                }


                var user = _userManager.FindByEmailAsync(userAuthentication.Email);
                

                
                
                var isSeller = false;
                if(user.Result.Role == "Seller")
                {
                    isSeller = true;

                }
                var tokenString = await _authenticationManager.CreateToken();

                return Ok(new {      
                    id = user.Result.Id,
                    username = user.Result.UserName,
                    email = user.Result.Email,
                    isSeller,
                    storename = user.Result.StoreName,
                    Token = tokenString }); 
            }
            catch (Exception ex)
            {

                _logger.Error(ex.Message);
                return StatusCode(500, ex.Message);
            }

        }

    }
}
