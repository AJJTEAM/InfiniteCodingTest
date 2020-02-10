using System.Collections.Generic;
using InfinitePeopleApi.Models;
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
        public ActionResult<IEnumerable<People>> Get() => new OkObjectResult(_personService.Get());
    }
}
