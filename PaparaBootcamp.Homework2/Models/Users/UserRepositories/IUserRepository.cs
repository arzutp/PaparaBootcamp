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
        List<User> GetByName(string name); //birden fazla aynı name e sahip user olabilir
        List<User> GetByAge(int age);  //birden fazla aynı yaşa sahip user olabilir
    }
}
