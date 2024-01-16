using PaparaBootcamp.Homework2.Models.Users.Entity;
using PaparaBootcamp.Homework2.Models.Data;

namespace PaparaBootcamp.Homework2.Models.Users.UserRepositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();
        public UserRepository() => _users = UserData.Users();

        public User Add(User user)
        {
            _users.Add(user);
            return user;
        }

        public void Delete(int id)
        {
            var userToDeleteIndex = _users.FindIndex(x => x.Id == id);
            _users.RemoveAt(userToDeleteIndex);
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public List<User> GetByAge(int age)
        {
            return _users.Where(u => u.Age == age).ToList();
        }

        public User GetById(int id)
        {
            User userGetById = _users.Where(user => user.Id == id).FirstOrDefault()!;
            return userGetById;
        }

        public List<User> GetByName(string name)
        {
            return _users.Where(u=>u.Name == name).ToList();
        }

        public void Update(User user)
        {
            var userToUpdateIndex = _users.FindIndex(u => u.Id == user.Id);
            _users[userToUpdateIndex].Name = user.Name;
            _users[userToUpdateIndex].Surname = user.Surname;
            _users[userToUpdateIndex].Email = user.Email;
            _users[userToUpdateIndex].Age = user.Age;
        }
    }
}
