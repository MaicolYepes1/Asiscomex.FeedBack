using Microsoft.AspNetCore.Mvc;
using Asiscomex.FeedBack.Models.Dtos;
using Asiscomex.FeedBack.Managers;
using Asiscomex.FeedBack.Models;

namespace Asiscomex.FeedBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserManager _userManager;
        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hola Mundo";
        }
        [HttpGet]
        [Route("Save")]
        public ActionResult<string> Hola()
        {
            _userManager.Add(new User()
            {
                Name = "Caquita",
                LastName = "Cacota"
            });
            return "holi";

        }
    }
}