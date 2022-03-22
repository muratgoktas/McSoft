using McSoft.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.DataAccsessLayer.Concrete.EntityFramework
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLOCALDB;DataBase=MYDATAS");
        }
        public DbSet<EducationInformation> EducationInformations { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
    }
}
