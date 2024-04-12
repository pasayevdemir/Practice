using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.Models;

namespace Account
{
    public class DB
    {
        private static DB _instance;
        public static DB Database
        {
            get
            {
                if(_instance is null)
                    _instance = new DB();
                return _instance;
            }
        }

        private DB()
        {
            
        }
        public List<User> users = new List<User>();
    }
}
