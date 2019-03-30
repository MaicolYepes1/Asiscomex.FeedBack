using Asiscomex.FeedBack.Models;
namespace Asiscomex.FeedBack.Managers
{
    public interface IUserManager
    {
        void Update(User user);
        int Add(User user);
        void Delete(int id);
    }
}
