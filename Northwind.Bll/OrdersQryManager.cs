using Northwind.Bll.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Dal.Abstract;

namespace Northwind.Bll
{
    public class OrdersQryManager : BllBase<OrdersQry, DtoOrdersQry>, IOrdersQryService
    {
        public readonly IOrdersQryRepository qryRepository;
        public OrdersQryManager(IServiceProvider service) : base(service)
        {
            qryRepository = service.GetService<IOrdersQryRepository>();
        }
    }
}
