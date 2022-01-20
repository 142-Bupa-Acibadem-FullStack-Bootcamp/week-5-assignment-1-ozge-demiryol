using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Interface;

namespace Northwind.Bll
{
    public class CurrentProductListManager : BllBase<CurrentProductList, DtoCurrentProductList>, ICurrentProductListService
    {
        public readonly ICurrentProductListRepository listRepository;
        public CurrentProductListManager(IServiceProvider service) : base(service)
        {
            listRepository = service.GetService<ICurrentProductListRepository>();
        }

        public IQueryable ProductListReport()
        {
            return listRepository.CurrentProductListReport();
        }
    }
}
