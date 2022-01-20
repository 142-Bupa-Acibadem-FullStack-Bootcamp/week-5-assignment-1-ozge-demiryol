using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public class DtoCustomerDemographic : DtoBase
    {
        /*public CustomerDemographic()
        {
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
        }*/

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        //public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
