using Asiscomex.FeedBack.Models;

namespace Asiscomex.FeedBack.Managers
{
    public class TaskManager : ITaskManager
    {
        private readonly AsiscomexDbContext _dbContext;

        public TaskManager(AsiscomexDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Task task)
        {
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
            return task.Id;
        }

        public void Update(Task task)
        {
            _dbContext.Tasks.Update(task);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = _dbContext.Tasks.Find(id);
            _dbContext.Tasks.Remove(task);
            _dbContext.SaveChanges();
        }
    }
}
