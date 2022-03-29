using McSoft.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.Entities.Dtos
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public class UserForRegisterDto:IDto
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
