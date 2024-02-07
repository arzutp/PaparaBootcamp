using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.UserDTOs
{
    public class UserWriteBaseDto
    {
        public string Username { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
