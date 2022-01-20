using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class SalesByCategoryManager : BllBase<SalesByCategory, DtoSalesByCategory>, ISalesByCategoryService
    {
        public readonly ISalesByCategoryRepository salesByCategoryRepository;
        public SalesByCategoryManager(IServiceProvider service) : base(service)
        {
            salesByCategoryRepository = service.GetService<ISalesByCategoryRepository>();
        }
    }
}
