namespace ExampleCQRS.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.Application.Enums;
    using ExampleCQRS.Application.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> Create()
        {
            var userDto = new UserDto() 
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@email.com",
                BirthDate = DateTime.Today.AddYears(-35)
            };

            var result = await this.userService.InsertAsync(userDto);

            return View();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody]UserDto user)
        {
            var result = await this.userService.InsertAsync(user);

            if(result.Status == ServiceResponseStatus.Success)
            {
                return Ok();
            }

            var errors = JsonConvert.SerializeObject(result);

            return BadRequest(errors);
        }
    }
}