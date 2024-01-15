namespace PaparaBootcamp.Homework2.Models.Users.Entity

{
    public class User
    {
        //User ( Id,Name,Surname,Age vb..) Entity
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
    }
}
