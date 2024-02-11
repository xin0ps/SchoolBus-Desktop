using Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concretes
{
    public class Student:UserBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ClassId { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }

        //Navigation Property
        public virtual Class? Class { get; set; }
      
        public virtual ICollection<StudentRide>? StudentRides { get; set; }

        public virtual ICollection<ParentStudent>? ParentStudents { get; set; }
    }
}
