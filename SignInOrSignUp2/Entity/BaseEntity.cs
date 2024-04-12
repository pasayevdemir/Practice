using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInOrSignUp2.Entity
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
