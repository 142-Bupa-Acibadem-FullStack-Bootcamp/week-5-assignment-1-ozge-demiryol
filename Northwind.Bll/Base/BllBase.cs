using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Northwind.Entity.IBase;
using Northwind.Entity.Mapper;
using Microsoft.AspNetCore.Http;

namespace Northwind.Bll.Base
{
    //Erisim belirtecini public yapmak ve Interface katmanindaki Generic interface'i implemente etmek gerekiyor. 
    //Bunun icin Interface katmanini burada referans gosteririz.
    //Bll katmanina sag tikla > Add Reference > Northwind.Interface
    public class BllBase<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variables
        private readonly IUnitOfWork unitOfWork;
        private readonly IServiceProvider service;
        private readonly IGenericRepository<T> repository;
        #endregion
        public BllBase(IServiceProvider service)
        {
            unitOfWork = service.GetService<IUnitOfWork>();
            repository = unitOfWork.GetRepository<T>();
            this.service = service;
        }

        public IResponse<TDto> Add(TDto item, bool saveChanges = true)
        {
            try
            {
                var resolvedResult = ""; 
                var TResult = repository.Add(ObjectMapper.Mapper.Map<T>(item)); //DTO'yu T'ye yani veri tabanindaki modele cevirir.
                resolvedResult = String.Join(',', TResult.GetType().GetProperties().Select(x => $" - {x.Name} : {x.GetValue(TResult) ?? ""} - "));
                
                if(saveChanges)
                   Save();
                
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<T, TDto>(TResult) //Soldaki veriyi sagdakine cevirir.
                };
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error: {ex.Message}",
                    Data = null
                };
            }
        }

        public Task<TDto> AddAsync(TDto item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TDto item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TDto item)
        {

            throw new NotImplementedException();
        }

        public IResponse<bool> DeleteById(int id, bool saveChanges=true)
        {
            try
            {
                repository.Delete(id);
                if(saveChanges) Save();
                return new Response<bool>
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = true
                };
            }
            catch(Exception ex)
            {
                return new Response<bool>
                {
                    Message = $"Error: {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = false
                };
            }
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse<TDto> Find(int id)
        {
            try
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<T, TDto>(repository.Find(id))
                };
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                List<T> list = repository.GetAll();
                var dtoList = list.Select(x => ObjectMapper.Mapper.Map<TDto>(x)).ToList();

                var response = new Response<List<TDto>>()
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data=dtoList
                };

                return response;
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    Message = $"Error: {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }

        }
        public IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression)
        {
            try
            {
                List<T> list = repository.GetAll(expression).ToList();
                var dtoList = list.Select(x => ObjectMapper.Mapper.Map<TDto>(x)).ToList();

                var response = new Response<List<TDto>>()
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = dtoList
                };

                return response;
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    Message = $"Error: {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

        public IQueryable<T> GetIQueryable()
        {
            throw new NotImplementedException();
        }

        public TDto Update(TDto item)
        {
            //Dto t'ye cevrilip kaydedilir dto dondurulur
            var TUpdate = repository.Update(ObjectMapper.Mapper.Map<T>(item));
            var DtoUpdate = ObjectMapper.Mapper.Map<TDto>(TUpdate);
            Save();
            return DtoUpdate;
        }

        public Task<TDto> UpdateAsync(TDto item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            unitOfWork.SaveChanges();
        }

    }
}
