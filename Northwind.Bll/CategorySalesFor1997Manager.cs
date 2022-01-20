using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CategorySalesFor1997Manager : BllBase<CategorySalesFor1997, DtoCategorySalesFor1997>, ICategorySalesFor1997Service
    {
        ICategorySalesFor1997Repository salesRepository;
        public CategorySalesFor1997Manager(IServiceProvider service) : base(service)
        {
            salesRepository = service.GetService<ICategorySalesFor1997Repository>();
        }

        public IQueryable CustomerReport()
        {
            return salesRepository.CategorySalesFor1997();
        }
    }
}
