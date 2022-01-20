using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Northwind.Bll
{
    public class CategoryManager : BllBase<Category, DtoCategory>, ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;
        public CategoryManager(IServiceProvider service) : base(service)
        {
            categoryRepository = service.GetService<ICategoryRepository>();
        }

        public IQueryable CategoryReport()
        {
            return categoryRepository.CategoryReport();
        }
    }
}
