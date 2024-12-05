using api.Models.Entities;
using api.Persistence;
using Microsoft.EntityFrameworkCore;

namespace api.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _db;

        public UserService(DataContext dataContext)
        {
            _db = dataContext;
        }

        public async Task<User> Create(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _db.Users.FindAsync(id);
            if (product == null) return false;

            _db.Users.Remove(product);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Exists(int id)
        {
            return await _db.Users.AnyAsync(entry => entry.Id == id);
        }

        public async Task<ICollection<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _db.Users.FindAsync(id);
        }

        public async Task<User> Update(User user)
        {
            var existingEntry = await _db.Users.FindAsync(user.Id);
            if (existingEntry == null) return null;

            existingEntry = user;

            await _db.SaveChangesAsync();
            return existingEntry;
        }
    }
}