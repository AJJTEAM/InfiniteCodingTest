using InfinitePeopleApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfinitePeopleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_personService.Get());
    }
}
