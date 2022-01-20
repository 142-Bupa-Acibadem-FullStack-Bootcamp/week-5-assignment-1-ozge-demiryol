using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesByCategoryController : ApiBaseController<ISalesByCategoryService, SalesByCategory, DtoSalesByCategory>
    {
        private readonly ISalesByCategoryService salesByCategoryService;
        public SalesByCategoryController(ISalesByCategoryService salesByCategoryService):base(salesByCategoryService)
        {
            this.salesByCategoryService = salesByCategoryService;
        }
    }
}
