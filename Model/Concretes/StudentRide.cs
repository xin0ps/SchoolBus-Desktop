using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concretes
{
    public class StudentRide
    {
        public int RideId { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Ride Ride { get; set; } = null!;
    }
}
