using api.Models.Entities;

namespace api.Services
{
    public interface IUserService
    {
        Task<User> Create(User user);
        Task<ICollection<User>> GetAll();
        Task<User> GetById(Guid id);
        Task<User> Update(User user);
        Task<bool> Delete(Guid id);
    }
}