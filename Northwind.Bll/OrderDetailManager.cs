using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class OrderDetailManager : BllBase<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        public readonly IOrderDetailRepository detailRepository;

        public OrderDetailManager(IServiceProvider service) : base(service)
        {
            detailRepository = service.GetService<IOrderDetailRepository>();
        }
    }
}
