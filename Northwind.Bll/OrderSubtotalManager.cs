using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class OrderSubtotalManager : BllBase<OrderSubtotal, DtoOrderSubtotal>, IOrderSubtotalService
    {
        public readonly IOrderSubtotalRepository subtotalRepository;
        public OrderSubtotalManager(IServiceProvider service): base(service)
        {
            subtotalRepository = service.GetService<IOrderSubtotalRepository>();
        }
    }
}
