using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
namespace Northwind.Bll
{
    public class SalesTotalsByAmountManager : BllBase<SalesTotalsByAmount, DtoSalesTotalsByAmount>, ISalesTotalsByAmountService
    {
        public readonly ISalesTotalsByAmountRepository salesTotalsByAmountRepository;
        public SalesTotalsByAmountManager(IServiceProvider service) : base(service)
        {
            salesTotalsByAmountRepository= service.GetService<ISalesTotalsByAmountRepository>();
        }
    }
}
