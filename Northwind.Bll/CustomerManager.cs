using Microsoft.AspNetCore.Http;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CustomerManager : BllBase<Customer, DtoCustomer>, ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerManager(IServiceProvider service) : base(service)
        {
            customerRepository = service.GetService<ICustomerRepository>();
        }

        public IQueryable CustomerReport()
        {
            return customerRepository.CustomerReport();
        }

        public IResponse<DtoCustomer> GetByStringId(string customerId)
        {
            try
            {
                return new Response<DtoCustomer>
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = ObjectMapper.Mapper.Map<Customer, DtoCustomer>(customerRepository.GetByStringId(customerId))
                };
            } 
            catch (Exception ex)
            {
                return new Response<DtoCustomer>
                {
                    Message = $"Error: {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

    }
}
