using Repository.Domain;

namespace Repository.Repositories;

public interface IUserRepository
{
    void Add(User user);
    User? GetById(Guid id);
    IEnumerable<User> GetAll();
}
