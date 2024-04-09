using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInOrUp
{
    public class UserManager
    {
        private List<User> Users { get; set; }
        public UserManager(List<User> users)
        {
            Users = users;
        }

        public bool SignIn(User user)
        {
            foreach (var item in Users)
            {
                if(user.UserName == item.UserName && user.Password == item.Password)
                {
                    return true;
                }
            }
            return false;
        }
        
        public bool SignUp(User user,string repeatPassword)
        {
            if(user.Password == repeatPassword)
            {
                Users.Add(user);
                return true;
            }
            else 
            return false;
        }

        public List<User> GetAll()
        {
            if (Users.Count==0)
            {
                return null;
            }

            return Users;
        }
    }
}
