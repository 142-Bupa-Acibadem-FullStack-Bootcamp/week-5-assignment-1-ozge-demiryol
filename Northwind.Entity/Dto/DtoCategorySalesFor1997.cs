using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    //Erisim belirtecini public olarak duzenlenir ve dtobase'ten kalitim verilir
    public class DtoCategorySalesFor1997 : DtoBase
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
