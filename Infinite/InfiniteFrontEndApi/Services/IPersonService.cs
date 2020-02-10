using System.Collections.Generic;
using System.Threading.Tasks;
using InfiniteFrontEndApi.Models;

namespace InfiniteFrontEndApi.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<People>> GetAsync();
    }
}
