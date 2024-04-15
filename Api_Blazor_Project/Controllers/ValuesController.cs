using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Blazor_Project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            return "Test By Joy";
        }


        [HttpGet]
        public string GetFullName()
        {
            return "Joy Krisno Ray";
        }




    }
}
