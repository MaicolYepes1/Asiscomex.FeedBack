using System;
using System.Collections.Generic;
using System.Linq;
using Asiscomex.FeedBack.Models;

namespace Asiscomex.FeedBack.Managers
{
    public interface ITaskManager
    {
        void Update(Task task);
        int Add(Task task);
        void Delete(int id);
    }
}
