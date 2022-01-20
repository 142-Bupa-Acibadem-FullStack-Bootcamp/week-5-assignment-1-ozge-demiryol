using Northwind.Bll.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Dal.Abstract;
using System;

namespace Northwind.Bll
{
    public class OrderDetailsExtendedManager : BllBase<OrderDetailsExtended, DtoOrderDetailsExtended>, IOrderDetailsExtendedService
    {
        public readonly IOrderDetailsExtendedRepository extendedRepository;
        public OrderDetailsExtendedManager(IServiceProvider service) : base(service)
        {
            extendedRepository = service.GetService<IOrderDetailsExtendedRepository>();
        }
    }
}
