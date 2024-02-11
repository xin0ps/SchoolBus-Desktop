using Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concretes
{
    public class Class:BaseEntity
    {
        public string Name { get; set; }

 //-----------------------------------------------------------//
        public virtual ICollection<Student>? Students { get; set; }
    }
}
