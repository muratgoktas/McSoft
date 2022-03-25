using McSoft.Core.DataAccess;
using McSoft.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.DataAccsessLayer.Abstract
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetCliams(User user);


    }
}
