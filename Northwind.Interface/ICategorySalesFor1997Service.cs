using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    //Erisim belirteci public olarak belirlenir ve IGenericService interface'inden kalitim verilir.
    public interface ICategorySalesFor1997Service : IGenericService<CategorySalesFor1997, DtoCategorySalesFor1997>
    {
        IQueryable CustomerReport();
    }
}
