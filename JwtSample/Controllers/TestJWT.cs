using JwtSample.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestJWT : ControllerBase
    {
        private IUserService _userService;

        public TestJWT(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Authorize(Roles = "admin,manager")]
        public ActionResult<IEnumerable<string>> Load()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<string> LoadOne(int id)
        {
            return "value";
        }
    }
}
