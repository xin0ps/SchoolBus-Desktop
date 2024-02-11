using Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concretes
{
    public class Car:BaseEntity
    {

        public string Name { get; set; }
        public string Number { get; set; }
        public int SeatCount { get; set; }
        //-----------------------------------------------------------//

        public virtual ICollection<Ride>? Rides { get; set; }
    }
}
