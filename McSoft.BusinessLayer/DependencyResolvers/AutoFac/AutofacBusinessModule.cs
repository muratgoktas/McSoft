using Autofac;
using McSoft.BusinessLayer.Abstract;
using McSoft.BusinessLayer.Concrete;
using McSoft.DataAccsessLayer.Abstract;
using McSoft.DataAccsessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.DependencyResolvers.AotoFac
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EducationInfoManager>().As<IEducationInfoService>();
            builder.RegisterType<EfEducationInfoDal>().As<IEducationInfoDal>();
            builder.RegisterType<PersonalInfoManager>().As<IPersonalInfoService>();
            builder.RegisterType<EfPersonalInfoDal>().As<IPersonalInfoDal>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

        }
    }
}
