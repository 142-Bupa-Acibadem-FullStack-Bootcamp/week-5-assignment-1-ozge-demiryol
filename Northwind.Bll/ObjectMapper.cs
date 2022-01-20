using AutoMapper;
using Northwind.Entity.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    //Varsayilan erisim belirteci internal olsa bile optimizasyon kuralları geregi internal yazmamiz gerekir.
    //BllBase ile Assembly'leri ayni oldugundan public yazmaya gerek yok.
    internal class ObjectMapper
    {
        //Lazy loading kullaniyoruz
        static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() => {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            return config.CreateMapper();
        });

        //lazy'nin value'sunu cagiran metod
        public static IMapper Mapper => lazy.Value;
    }
}
