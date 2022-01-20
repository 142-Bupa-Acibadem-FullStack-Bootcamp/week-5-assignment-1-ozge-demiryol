using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerRepository
    {
        IQueryable CustomerReport();
        Customer GetByStringId(string customerId);
    }
}
