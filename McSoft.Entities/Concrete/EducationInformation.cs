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
    public class EducationInformation : IEntity
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public string EducationName { get; set; }
        public byte EducationType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Garduate{ get; set; }
        public decimal Degree { get; set; }
    }
}
