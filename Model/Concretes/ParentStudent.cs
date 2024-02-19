using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concretes
{
    public class ParentStudent
    {
        public int ParentId { get; set; }
        public int StudentId { get; set; }

        //-----------------------------------------------------------//
        public virtual Parent? Parent { get; }
        public virtual Student? Student { get; }
    }
}
