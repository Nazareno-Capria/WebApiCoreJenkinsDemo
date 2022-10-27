using Microsoft.AspNetCore.Mvc;

namespace CoreWebApiJenkinsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {

        private static string[] Names = {"Nazareno", "Adrian", "Jose", "Raul", "Julito" };


        public PeopleController()
        {

        }


        [HttpGet]
        public string GetName()
        {
            return Names[Random.Shared.Next(Names.Length)];
        }
    }
}
