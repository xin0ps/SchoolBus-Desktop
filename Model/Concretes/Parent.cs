using Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concretes
{
    public class Parent:UserBaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

      
        public virtual ICollection<ParentStudent> ParentStudents { get; set; } = new List<ParentStudent>();
    }
}
