using MathNet.Numerics.Statistics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserJWT.Services.Interfaces;
using UserJWT.Models;

namespace UserJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }



        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            var users = await _user.AddUser(user);
            return Ok(users);
        }

        [HttpGet]
        public async Task<ActionResult<User>> FindUSerById(string username)
        {
            try
            {
                var User = await _user.FindUSerByName(username);
                return Ok(User);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }


        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(int UserId, User user)
        {
            try
            {
                var User = await _user.UpdateUser(UserId, user);
                return Ok(User);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }


        }

        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUserById(int UserId)
        {
            try
            {
                var User = await _user.DeleteUserById(UserId);
                return Ok(User);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
