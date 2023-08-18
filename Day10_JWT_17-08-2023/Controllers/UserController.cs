using MathNet.Numerics.Statistics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserJWT.Services.Interfaces;
using UserJWT.Models;
using Microsoft.AspNetCore.Authorization;

namespace UserJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;
        private IToken _token;
        public UserController(IUser user, IToken token)
        {
            _user = user;
            _token = token;
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
                var token = _token.GeneraterToken(User.UserName, User.isAdmin);
                Console.WriteLine(token);
                return Ok(token);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }


        [HttpPut]
        [Authorize(Roles ="Admin")]
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
