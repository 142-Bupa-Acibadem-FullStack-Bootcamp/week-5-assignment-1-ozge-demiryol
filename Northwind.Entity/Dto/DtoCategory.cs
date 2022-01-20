using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    //Erisim belirtecini public olarak duzenlenir ve dtobase'ten kalitim verilir
    public class DtoCategory : DtoBase
    {
        public DtoCategory()
        {
            
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
    }
}
