using McSoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.Entities.Concrete
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public class PersonalInformation:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; }
        public bool MaritalStatus { get; set; }
        public bool MilitaryStatus { get; set; }
        public DateTime MilitaryEndDate { get; set; }
        public string PhotoLink { get; set; }
    }
}
