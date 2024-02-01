using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Abstract.ProductServide;
using BusinessLayer.Abstract.UserService;
using BusinessLayer.Concrete.CategoryManager;
using BusinessLayer.Concrete.ProductManager;
using BusinessLayer.Concrete.UserManager;
using DataAccessLayer.Abstract.CategoryRepository;
using DataAccessLayer.Abstract.ProductRepository;
using DataAccessLayer.Abstract.UserRepository;
using DataAccessLayer.Concrete.EntityFramework.CategoryRepositories;
using DataAccessLayer.Concrete.EntityFramework.ProductRepositories;
using DataAccessLayer.Concrete.EntityFramework.UserRepositories;
using DataAccessLayer.UnitOfWorks;
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
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICategoryWriteService, CategoryWriteManager>();

            services.AddScoped<IProductReadService, ProductReadManager>();
            services.AddScoped<IProductWriteService, ProductWriteManager>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IUserReadService, UserReadManager>();
            services.AddScoped<IUserWriteService, UserWriteManager>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
