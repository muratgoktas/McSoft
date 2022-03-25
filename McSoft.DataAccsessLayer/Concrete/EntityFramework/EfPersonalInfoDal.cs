using McSoft.Core.DataAccess.EntityFramework;
using McSoft.DataAccsessLayer.Abstract;
using McSoft.Entities.Concrete;
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
    public class EfPersonalInfoDal : EfEntityRepositoryBase<PersonalInformation, Context>, IPersonalInfoDal
    {
    }
}
