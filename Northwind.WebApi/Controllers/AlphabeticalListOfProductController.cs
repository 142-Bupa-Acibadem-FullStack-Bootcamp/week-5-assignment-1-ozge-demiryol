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
    public class AlphabeticalListOfProductController : ApiBaseController<IAlphabeticalListOfProductService, AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>
    {
        private readonly IAlphabeticalListOfProductService productService;

        public AlphabeticalListOfProductController(IAlphabeticalListOfProductService productService) : base(productService)
        {
            this.productService = productService;
        }
    }
}
