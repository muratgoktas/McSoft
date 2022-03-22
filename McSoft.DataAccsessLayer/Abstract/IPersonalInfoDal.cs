using McSoft.Core.DataAccess;
using McSoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.DataAccsessLayer.Abstract
{
    public interface IPersonalInfoDal: IEntityRepository<PersonalInformation>
    {
    }
}
