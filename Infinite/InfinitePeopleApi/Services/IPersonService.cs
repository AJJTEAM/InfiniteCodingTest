using System.Collections.Generic;
using InfinitePeopleApi.Models;

namespace InfinitePeopleApi.Services
{
    public interface IPersonService
    {
        IEnumerable<People> Get();
    }
}
