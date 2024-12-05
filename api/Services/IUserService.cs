using api.Models.Entities;

namespace api.Services
{
    public interface IUserService
    {
        Task<User> Create(User user);

        Task<bool> Delete(int id);

        Task<bool> Exists(int id);

        Task<ICollection<User>> GetAll();

        Task<User> GetById(int id);

        Task<User> Update(User user);
    }
}