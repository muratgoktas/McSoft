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
    public interface IEducationInfoService : IService
    {
        IDataResult<EducationInformation> GetbyId(int Id);
        IDataResult<List<EducationInformation>> GetList();
        IDataResult<List<EducationInformation>> GetbyPersonal(int personalId);
        IResult Add(EducationInformation educationInfo);
        IResult Delete(EducationInformation educationInfo);
        IResult Update(EducationInformation educationInfo);


    }
}
