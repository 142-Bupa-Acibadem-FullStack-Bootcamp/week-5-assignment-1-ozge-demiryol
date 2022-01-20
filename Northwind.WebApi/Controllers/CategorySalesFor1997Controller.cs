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
    public class CategorySalesFor1997Controller : ApiBaseController<ICategorySalesFor1997Service, CategorySalesFor1997, DtoCategorySalesFor1997>
    {
        private readonly ICategorySalesFor1997Service categoryService;
        public CategorySalesFor1997Controller(ICategorySalesFor1997Service categoryService) : base(categoryService)
        {
            this.categoryService = categoryService;
        }
    }
}
