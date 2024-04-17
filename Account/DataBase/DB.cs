

namespace Models
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
