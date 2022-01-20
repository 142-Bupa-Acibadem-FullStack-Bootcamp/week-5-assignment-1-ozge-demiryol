using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryOfSalesByQuarterController : ApiBaseController<ISummaryOfSalesByQuarterService, SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>
    {
        private readonly ISummaryOfSalesByQuarterService summaryOfSalesByQuarterService;
        public SummaryOfSalesByQuarterController(ISummaryOfSalesByQuarterService summaryOfSalesByQuarterService):base(summaryOfSalesByQuarterService)
        {
            this.summaryOfSalesByQuarterService = summaryOfSalesByQuarterService;
        }
    }
}
