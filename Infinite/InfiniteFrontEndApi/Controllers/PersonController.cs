using System.Threading.Tasks;
using InfiniteFrontEndApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfiniteFrontEndApi.Controllers
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
        public async Task<IActionResult> Get() => Ok(await _personService.GetAsync());
    }
}
