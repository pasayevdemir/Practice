using Models;

namespace Account
{
    public interface IUserOperation
    {
        bool HasUser(User user,out User outUser);
    }
}
