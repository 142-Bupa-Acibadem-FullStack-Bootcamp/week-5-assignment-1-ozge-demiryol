using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class RegionManager : BllBase<Region, DtoRegion>, IRegionService
    {
        public readonly IRegionRepository regionRepository;
        public RegionManager(IServiceProvider service) :base(service)
        {
            regionRepository = service.GetService<IRegionRepository>();
        }
    }
}
