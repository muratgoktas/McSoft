using McSoft.Core.Entities.Concrete;
using McSoft.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
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
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLOCALDB;DataBase=MYDATAS");
        }
        public DbSet<EducationInformation> EducationInformations { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
