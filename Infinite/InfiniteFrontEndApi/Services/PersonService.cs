using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using InfiniteFrontEndApi.HttpClientModel;
using InfiniteFrontEndApi.Models;
using Newtonsoft.Json;

namespace InfiniteFrontEndApi.Services
{
    public class PersonService:IPersonService
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;
        public PersonService(HttpClient httpClient, IMapper mapper)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }

        public async Task<IEnumerable<People>> GetAsync()
        {
           var responseString = await _httpClient.GetStringAsync("api/person");
           return _mapper.Map<IEnumerable<People>>(JsonConvert.DeserializeObject<PeopleClientResponse[]>(responseString)) ;
        }
    }
}
