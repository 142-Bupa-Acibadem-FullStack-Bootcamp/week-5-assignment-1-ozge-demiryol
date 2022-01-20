using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class SummaryOfSalesByQuarterManager : BllBase<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>, ISummaryOfSalesByQuarterService
    {
        public readonly ISummaryOfSalesByQuarterRepository summaryOfSalesByQuarterRepository;
        public SummaryOfSalesByQuarterManager(IServiceProvider service) : base(service)
        {
            summaryOfSalesByQuarterRepository= service.GetService<ISummaryOfSalesByQuarterRepository>();
        }
    }
}
