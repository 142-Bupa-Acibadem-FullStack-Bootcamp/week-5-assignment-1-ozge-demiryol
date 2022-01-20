using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSalesFor1997Controller : ApiBaseController<IProductSalesFor1997Service, ProductSalesFor1997, DtoProductSalesFor1997>
    {
        private readonly IProductSalesFor1997Service productSalesService;

        public ProductSalesFor1997Controller(IProductSalesFor1997Service productSalesService): base(productSalesService)
        {
            this.productSalesService = productSalesService;
        }
    }
}
