﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseEntity
    {
        private static int _id = 0;
        public int ID { get; set; }
        public BaseEntity()
        {
            ID = ++_id;
        }
    }
}
