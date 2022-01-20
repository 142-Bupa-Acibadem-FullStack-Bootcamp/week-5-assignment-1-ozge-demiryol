using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class ProductsByCategoryManager : BllBase<ProductsByCategory, DtoProductsByCategory>, IProductsByCategoryService
    {
        public readonly IProductsByCategoryRepository productCategoryRepository;

        public ProductsByCategoryManager(IServiceProvider service) : base(service)
        {
            productCategoryRepository = service.GetService<IProductsByCategoryRepository>();
        }
    }
}
