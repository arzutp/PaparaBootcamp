using System.ComponentModel.DataAnnotations;

namespace PaparaBootcamp.Homework2.Models.Users.DTOs
{
    public class BaseUserDto
    {

        //userName alanı en fazla 10 karakter olacaktır, Yaş aralığı 18-64 arasında olacaktır.

        [StringLength(10, ErrorMessage = "Kullanıcı adı en fazla en 10 karakter olmalıdır!")]
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Kullanıcı soyadı boş geçilemez")]
        public string Surname { get; set; } = null!;

        [Required(ErrorMessage = "Kullanıcı mail adresi boş geçilemez")]
        public string Email { get; set; } = null!;

        [Range(18,64, ErrorMessage ="Kullanıcı yaşı 18 - 64 arası olmalıdır!")]
        [Required(ErrorMessage = "Kullanıcı yaşı boş geçilemez")]
        public int Age { get; set; }
    }
}
