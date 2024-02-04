using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Services
{
    public class UserService : IUserService
    {
        private readonly DBContext _dbContext;

        public UserService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task CreateUser(User user)
        {
            await  _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(string name)
        {
            var user = await GetUserByName(name);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<User?> GetUserByName(string name)
        {
            return await _dbContext.Users.Where(users => users.Name.Equals(name)).FirstOrDefaultAsync();
        }

        public async Task UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> SearchByName(string search)
        {
            return await _dbContext.Users.Where(users => users.Name.Contains(search.ToLower())).ToListAsync();
        }
    }
}
