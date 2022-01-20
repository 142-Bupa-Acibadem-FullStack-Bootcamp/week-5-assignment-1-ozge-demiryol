using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class CustomerAndSuppliersByCityManager : BllBase <CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        public readonly ICustomerAndSuppliersByCityRepository suppliersRepository;
        public CustomerAndSuppliersByCityManager(IServiceProvider service) : base(service)
        {
            suppliersRepository = service.GetService<ICustomerAndSuppliersByCityRepository>();
        }
    }
}
