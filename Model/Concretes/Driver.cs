using Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concretes
{
    public class Driver:UserBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string HomeAddress { get; set; }
        public string License { get; set; }

        //-----------------------------------------------------------//
        public virtual ICollection<Ride>? Rides { get; set; }
    }
}
