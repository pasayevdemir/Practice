using SignInOrSignUp2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInOrSignUp2.DataBase
{
    public class DB
    {
        private static DB _dB;
        public static DB DataBase
        {
            get
            {
                if(_dB == null)
                    _dB = new DB();
                return _dB;
            }
        }
        private DB()
        {
            
        }
        
        public List<User> users = new List<User>();
    }
}
