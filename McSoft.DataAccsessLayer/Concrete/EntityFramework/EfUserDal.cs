using McSoft.Core.DataAccess.EntityFramework;
using McSoft.Core.Entities.Concrete;
using McSoft.DataAccsessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.DataAccsessLayer.Concrete.EntityFramework
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public class EfUserDal : EfEntityRepositoryBase<User, Context>, IUserDal
    {
        public List<OperationClaim> GetCliams(User user)
        {
            // Join işlemi
            using (var myContext=new Context())
            {
                var result = from operationClaim in myContext.OperationClaims
                             join userOperationClaim in myContext.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

    }
}
