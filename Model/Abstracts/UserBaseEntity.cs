﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstracts
{
    public abstract class UserBaseEntity:BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
