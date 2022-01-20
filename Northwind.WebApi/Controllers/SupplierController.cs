using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ApiBaseController<ISupplierService, Supplier, DtoSupplier>
    {
        private readonly ISupplierService supplierService;
        public SupplierController(ISupplierService supplierService) : base(supplierService)
        {
            this.supplierService = supplierService;
        }
    }
}
