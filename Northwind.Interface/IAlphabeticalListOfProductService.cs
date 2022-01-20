using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    //Erisim belirteci public olarak belirlenir ve IGenericService'ten kalitim verilir
    public interface IAlphabeticalListOfProductService : IGenericService<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>
    {
        IQueryable ProductReport();
    }
}
