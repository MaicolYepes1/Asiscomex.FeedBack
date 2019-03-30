using Asiscomex.FeedBack.Managers;
using Asiscomex.FeedBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asiscomex.FeedBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskManager _taskManager;
        private readonly IUserManager _userManager;
        public TaskController(ITaskManager taskManager, IUserManager userManager)
        {
            _taskManager = taskManager;
            _userManager = userManager;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            _taskManager.Add(new Task()
            {
                Name = "Juan"
            });
            return "Hola Mundo";
        }
    }
}