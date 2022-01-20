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
    public class AlphabeticalListOfProductManager : BllBase<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>, IAlphabeticalListOfProductService
    {
        public readonly IAlphabeticalListOfProductRepository alphabeticalRepository;
        public AlphabeticalListOfProductManager(IServiceProvider service) : base(service)
        {
            alphabeticalRepository = service.GetService<IAlphabeticalListOfProductRepository>();
        }

        public IQueryable ProductReport()
        {
            return alphabeticalRepository.AlphabeticalListOfProductReport();
        }
    }
}
