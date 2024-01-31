using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract.CategoryRepository;
using DataAccessLayer.Concrete.EntityFramework.CategoryRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DIContainer
{
    public static class DIContainerExtension
    {
        public static void DIContainerExt(this IServiceCollection services)
        {
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryReadService, CategoryReadManager>();

        }
    }
}
