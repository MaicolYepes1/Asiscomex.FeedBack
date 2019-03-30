namespace Asiscomex.FeedBack.Managers
{
    using Asiscomex.FeedBack.Models;
    public class UserManager : IUserManager
    {
        private readonly AsiscomexDbContext _dbContext;
        
        public UserManager(AsiscomexDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user.Id;
        }

        public void Update(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _dbContext.Users.Find(id);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
    }   
}
