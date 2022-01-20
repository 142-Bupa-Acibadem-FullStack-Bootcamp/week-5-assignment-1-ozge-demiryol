using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    //Erisim belirtecini public olarak duzenlenir ve dtobase'ten kalitim verilir
    public class DtoCurrentProductList : DtoBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
