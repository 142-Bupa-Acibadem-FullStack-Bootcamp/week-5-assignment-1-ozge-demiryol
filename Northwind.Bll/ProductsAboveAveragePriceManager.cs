using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class ProductsAboveAveragePriceManager : BllBase<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>, IProductsAboveAveragePriceService
    {
        public readonly IProductsAboveAveragePriceRepository priceRepository;
        public ProductsAboveAveragePriceManager(IServiceProvider service):base(service)
        {
            priceRepository = service.GetService<IProductsAboveAveragePriceRepository>();
        }
    }
}
