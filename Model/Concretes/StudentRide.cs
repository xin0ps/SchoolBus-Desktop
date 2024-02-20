﻿using System;
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

        public StudentRide()
        {
                
        }
        //-----------------------------------------------------------//

        public virtual Student Student { get; set; }
        public virtual Ride Ride { get; set; } 
    }
}
