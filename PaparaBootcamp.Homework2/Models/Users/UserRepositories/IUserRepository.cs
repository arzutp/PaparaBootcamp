using PaparaBootcamp.Homework2.Models.Users.Entity;

namespace PaparaBootcamp.Homework2.Models.Users.UserRepositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Add(User user);
        void Update(User user);
        void Delete(int  id);
        User GetById(int id);
    }
}
