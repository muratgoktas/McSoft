using McSoft.Core.DataAccess.EntityFramework;
using McSoft.DataAccsessLayer.Abstract;
using McSoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.DataAccsessLayer.Concrete.EntityFramework
{
    public class EfEducationInfoDal : EfEntityRepositoryBase<EducationInformation, Context> , IEducationInfoDal
    {

    }
}
