using UserJWT.Models;
namespace UserJWT.Services.Interfaces
{
    public interface IUser
    {
        Task<List<User>> AddUser(User user);

        Task<User> FindUSerByName(string username);

        Task<User> UpdateUser(int UserId, User user);

        Task<List<User>> DeleteUserById(int UserId);
    }
}
