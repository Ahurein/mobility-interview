using WebProject.Models;

namespace WebProject.Services
{
    public interface IUserService
    {
        Task CreateUser(User user);
        Task DeleteUser(string name);
        Task UpdateUser(User user);
        Task<List<User>> GetAllUsers();
        Task<User?> GetUserById(int id);
        Task<User?> GetUserByName(string name);
        Task<List<User>> SearchByName(string search);
    }
}
