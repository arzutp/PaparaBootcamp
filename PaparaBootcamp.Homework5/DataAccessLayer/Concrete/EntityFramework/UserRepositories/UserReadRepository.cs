using DataAccessLayer.Abstract.UserRepository;
using DataAccessLayer.Contexts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.UserRepositories
{
    public class UserReadRepository : BaseReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(PaparaHomeworkDbContext paparaHomeworkDbContext) : base(paparaHomeworkDbContext)
        {
        }
    }
}
