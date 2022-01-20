using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class SummaryOfSalesByYearManager : BllBase<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>, ISummaryOfSalesByYearService
    {
        public readonly ISummaryOfSalesByYearRepository summaryOfSalesByYearRepository;
        public SummaryOfSalesByYearManager(IServiceProvider service) : base(service)
        {
            summaryOfSalesByYearRepository= service.GetService<ISummaryOfSalesByYearRepository>();
        }
    }
}
