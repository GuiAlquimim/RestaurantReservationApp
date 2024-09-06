using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservationApp.Data.Interfaces;
using RestaurantReservationApp.DTOs;
using RestaurantReservationApp.Models;
using RestaurantReservationApp.Services;

namespace RestaurantReservationApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetUsers();

            return Ok(users);
        }

        [HttpGet("dto")]
        public IActionResult GetUsersDTO()
        {
            return Ok(_userService.GetUsersDTO());
        }

        [HttpGet("{id:int:min(1)}")]
        public IActionResult GetUserByIdDTO(int id)
        {
            return Ok(_userService.GetUserByIdDTO(id));
        }

        [HttpPost]
        public IActionResult InsertUser(UserInsertDTO userInsertDTO)
        {
            return Ok(_userService.InsertUser(userInsertDTO));
        }

        [HttpPut]
        public IActionResult UpdateUser(UserUpdateDTO userUpdateDTO)
        {
            return Ok(_userService.UpdateUser(userUpdateDTO));
        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            return Ok(_userService.DeleteUser(id));
        }
    }
}