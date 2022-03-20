using McSoft.BusinessLayer.Abstract;
using McSoft.BusinessLayer.Constance;
using McSoft.Core.Services;
using McSoft.Core.Utilities.Result;
using McSoft.DataAccsessLayer.Abstract;
using McSoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Concrete
{
    public class EducationInfoManager : IEducationInfoService
    {
        private IEducationInfoDal _educationDal;

        public EducationInfoManager(IEducationInfoDal educationDal)
        {
            _educationDal = educationDal;
        }

        public IDataResult<EducationInformation> GetbyId(int Id)
        {
            return new SuccessDataResult<EducationInformation>(_educationDal.Get(p => p.Id == Id));
        }
        public IDataResult<List<EducationInformation>> GetList()
        {
            return new SuccessDataResult<List<EducationInformation>>(_educationDal.GetAll().ToList());
        }
        public IDataResult<List<EducationInformation>> GetbyPersonal(int personalId)
        {
            return new SuccessDataResult<List<EducationInformation>>(_educationDal.GetAll(p => p.PersonalId == personalId).ToList());
        }

        public IResult  Add(EducationInformation educationInfo)
        {
           _educationDal.Add(educationInfo);
          return new   SuccessResult(Messages.addedMessage);
            
        }

        public IResult Delete(EducationInformation educationInfo)
        {
            _educationDal.Delete(educationInfo);
            return new SuccessResult(Messages.deletedMessage);
        }

        public IResult Update(EducationInformation educationInfo)
        {
            _educationDal.Update(educationInfo);
            return new SuccessResult(Messages.updatedMessage);

        }

       
    }
}
