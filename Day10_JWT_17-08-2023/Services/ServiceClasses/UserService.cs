using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using UserJWT.Models;
using UserJWT.Services.Interfaces;

namespace UserJWT.Services.ServiceClasses
{
    public class UserService : IUser
    {
        private StudentDbContext _StudentDbContext;

        public UserService(StudentDbContext studentDbContext)
        {
            _StudentDbContext = studentDbContext;
        }

        public async Task<List<User>> AddUser(User user)
        {
            _StudentDbContext.Users.Add(user);
            await _StudentDbContext.SaveChangesAsync();
            return await _StudentDbContext.Users.ToListAsync();
        }


        public async Task<User> FindUSerByName(string username)
        {
            var User = await _StudentDbContext.Users.FirstOrDefaultAsync(x => x.UserName == username);
            if (User == null)
            {
                throw new Exception("User not found");
            }
            else
            {
                return User;
            }
        }

        public async Task<User> UpdateUser(int UserId, User user)
        {
            User User;
            User = await _StudentDbContext.Users.FindAsync(UserId);
            if (User == null)
            {
                throw new Exception("User not found");

            }
            else
            {
                User.UserName = user.UserName;
                User.UserEmail = user.UserEmail;
                
                await _StudentDbContext.SaveChangesAsync();

                return await _StudentDbContext.Users.FindAsync(UserId);
            }
        }

        public async Task<List<User>> DeleteUserById(int UserId)
        {
            var User = await _StudentDbContext.Users.FindAsync(UserId);
            if (User == null)
            {
                throw new Exception("User not found");
            }
            else
            {
                _StudentDbContext.Users.Remove(User);
                await _StudentDbContext.SaveChangesAsync();

                return await _StudentDbContext.Users.ToListAsync();
            }
        }
    }
}
