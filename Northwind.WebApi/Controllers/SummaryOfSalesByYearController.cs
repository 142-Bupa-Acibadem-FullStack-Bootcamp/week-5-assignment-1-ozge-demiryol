using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SummaryOfSalesByYearController : ApiBaseController<ISummaryOfSalesByYearService, SummaryOfSalesByYear, DtoSummaryOfSalesByYear>
    {
        private readonly ISummaryOfSalesByYearService summaryOfSalesByYearService;
        public SummaryOfSalesByYearController(ISummaryOfSalesByYearService summaryOfSalesByYearService):base(summaryOfSalesByYearService)
        {
            this.summaryOfSalesByYearService = summaryOfSalesByYearService;
        }
    }
}
