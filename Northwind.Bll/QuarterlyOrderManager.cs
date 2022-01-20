using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class QuarterlyOrderManager : BllBase<QuarterlyOrder, DtoQuarterlyOrder>, IQuarterlyOrderService
    {
        public readonly IQuarterlyOrderRepository quarterlyOrderRepository;
        public QuarterlyOrderManager(IServiceProvider service):base(service)
        {
            quarterlyOrderRepository = service.GetService<IQuarterlyOrderRepository>();
        }
    }
}
