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
    public class OrderDetailController : ApiBaseController<IOrderDetailService, OrderDetail, DtoOrderDetail>
    {
        private readonly IOrderDetailService detailService;
        public OrderDetailController(IOrderDetailService detailService) : base(detailService)
        {
            this.detailService = detailService;
        }
    }
}
