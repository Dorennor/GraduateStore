using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GraduateStore.Dtos;
using GraduateStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace GraduateStore.Controllers
{
    [Route("api/v1/messages")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginDto userLoginDto)
        {
            User user = new User { Email = userLoginDto.Email};
            var result = await _signInManager.PasswordSignInAsync(user.Email, userLoginDto.Password, false, true);
            Console.WriteLine(userLoginDto.Email);
            return NoContent();
        }
    }
}
