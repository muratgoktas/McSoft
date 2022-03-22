using McSoft.BusinessLayer.Abstract;
using McSoft.BusinessLayer.Constance;
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
    public class PersonalInfoManager : IPersonalInfoService
    {
        private IPersonalInfoDal _personalInfoDal;

        public PersonalInfoManager(IPersonalInfoDal personalInfoDal)
        {
            _personalInfoDal = personalInfoDal;
        }

        public IResult Add(PersonalInformation personalInfo)
        {
            _personalInfoDal.Add(personalInfo);
            return new SuccessResult(Messages.addedMessage);
        }

        public IResult Delete(PersonalInformation personalInfo)
        {
            _personalInfoDal.Delete(personalInfo);
            return new SuccessResult(Messages.deletedMessage);
        }

        public IDataResult<PersonalInformation> GetbyId(int Id)
        {
            return new SuccessDataResult<PersonalInformation>(_personalInfoDal.Get(p => p.Id == Id));
        }

        public IDataResult<List<PersonalInformation>> GetbyPersonal(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonalInformation>> GetList()
        {
            return new SuccessDataResult<List<PersonalInformation>>(_personalInfoDal.GetAll().ToList());
        }

        public IResult Update(PersonalInformation personalInfo)
        {
            _personalInfoDal.Update(personalInfo);
            return new SuccessResult(Messages.updatedMessage);
        }
    }
}
