using PaparaBootcamp.Homework2.Models.Users.Entity;

namespace PaparaBootcamp.Homework2.Models.Data
{
    public static class UserData
    { 
        private static readonly List<User> users = new List<User>();
        public static List<User> Users()
        {
            if(users.Count == 0)
            {
                users.Add(new User() { Id = 1, Name = "Aslı", Surname = "Ata", Email = "asliata@gmail.com", Age = 23 });
                users.Add(new User() { Id = 2, Name = "Ahmet", Surname = "Aslan", Email = "ahmet@gmail.com", Age = 27 });
                users.Add(new User() { Id = 3, Name = "Arda", Surname = "Aslan", Email = "arda@gmail.com", Age = 43 });
                users.Add(new User() { Id = 4, Name = "Kerime", Surname = "Işık", Email = "kerime@gmail.com", Age = 37 });
                users.Add(new User() { Id = 5, Name = "Ali", Surname = "Öz", Email = "ali@gmail.com", Age = 19 });
                users.Add(new User() { Id = 1, Name = "Aslı", Surname = "Sütçüoğlu", Email = "asli@gmail.com", Age = 29 });
                users.Add(new User() { Id = 1, Name = "Volkan", Surname = "Sütçüoğlu", Email = "volkan@gmail.com", Age = 32 });
                users.Add(new User() { Id = 1, Name = "Sacit", Surname = "Kral", Email = "sacit@gmail.com", Age = 29 });
                users.Add(new User() { Id = 1, Name = "Burhan", Surname = "Altıntop", Email = "burhan@gmail.com", Age = 32 });
            }
            return users;
        }
    }
}
