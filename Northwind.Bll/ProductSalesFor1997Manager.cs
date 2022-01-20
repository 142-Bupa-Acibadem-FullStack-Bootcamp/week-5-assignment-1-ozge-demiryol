using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
namespace Northwind.Bll
{
    public class ProductSalesFor1997Manager : BllBase<ProductSalesFor1997, DtoProductSalesFor1997>, IProductSalesFor1997Service
    {
        public readonly IProductSalesFor1997Repository productSalesRepository;
        public ProductSalesFor1997Manager(IServiceProvider service) : base(service)
        {
            productSalesRepository = service.GetService<IProductSalesFor1997Repository>();
        }
    }
}
