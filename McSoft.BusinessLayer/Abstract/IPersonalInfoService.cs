using McSoft.Core.Services;
using McSoft.Core.Utilities.Result;
using McSoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Abstract
{
    public interface IPersonalInfoService:IService
    {
        IDataResult<PersonalInformation> GetbyId(int Id);
        IDataResult<List<PersonalInformation>> GetList();
        IDataResult<List<PersonalInformation>> GetbyPersonal(int Id);
        IResult Add(PersonalInformation personalInfo);
        IResult Delete(PersonalInformation personalInfo);
        IResult Update(PersonalInformation personalInfo);
    }
}
