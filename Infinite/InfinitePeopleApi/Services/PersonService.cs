using System.Collections.Generic;
using InfinitePeopleApi.Models;

namespace InfinitePeopleApi.Services
{
    public class PersonService: IPersonService
    {
        public IEnumerable<People> Get() => GetMockData();
        private static IEnumerable<People> GetMockData() => new List<People>
        {
            new People{GivenName = "John", FamilyName = "Doe", Address = "123 high street",Age = 24},
            new People{GivenName = "Patrick", FamilyName = "Kirk", Address = "23 happy road",Age = 23},
            new People{GivenName = "James", FamilyName = "Smith", Address = "22 sharp close",Age = 22},
            new People{GivenName = "Alan", FamilyName = "Pears", Address = "21 state street",Age = 21},
            new People{GivenName = "Andrew", FamilyName = "Lloyd", Address = "20 stars road",Age = 20}
        };
    }
}
