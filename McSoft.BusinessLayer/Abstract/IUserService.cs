
using McSoft.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Abstract
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public interface IUserService
    {
        List<OperationClaim> GetAll(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
