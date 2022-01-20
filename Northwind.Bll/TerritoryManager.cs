using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class TerritoryManager : BllBase<Territory, DtoTerritory>, ITerritoryService
    {
        public readonly ITerritoryRepository territoryRepository;
        public TerritoryManager(IServiceProvider service) : base(service)
        {
            territoryRepository= service.GetService<ITerritoryRepository>();
        }
    }
}
