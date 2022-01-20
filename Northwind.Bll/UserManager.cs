using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using Northwind.Entity.IBase;
using Northwind.Entity.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Northwind.Bll
{
    //API katmaninda singleton olarak kullanacagimiz icin public
    public class UserManager : BllBase<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;
        IConfiguration configuration;

        public UserManager(IServiceProvider service, IConfiguration configuration) : base (service)
        {
            userRepository = service.GetService<IUserRepository>();
            this.configuration = configuration;
        }
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));

            if (user != null)
            {
                var dtoUser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);
                var token = new TokenManager(configuration).CreateAccessToken(dtoUser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoUser,
                    AccessToken = token
                };

                return new Response<DtoUserToken>
                {
                    Message = "Token is created",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            } 
            else
            {
                return new Response<DtoUserToken>()
                {
                    Message = "User code or password is wrong" ,
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
            //return;
        }
    }
}
