using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public class DtoLogin
    {
        //Klavyeden kullanici adi(ya da e-posta, TC kimlik no gibi unique bir bilgi) ve sifreyi almak icin bu class'i olusturduk.
        [Required]
        public string UserCode { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
