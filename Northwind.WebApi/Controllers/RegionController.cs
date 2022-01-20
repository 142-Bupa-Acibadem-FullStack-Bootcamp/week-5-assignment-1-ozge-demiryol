using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ApiBaseController<IRegionService, Region, DtoRegion>
    {
        private readonly IRegionService regionService;
        public RegionController(IRegionService regionService) : base(regionService)
        {
            this.regionService = regionService;
        }
    }
}
