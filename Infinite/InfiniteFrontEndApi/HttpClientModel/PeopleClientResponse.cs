using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfiniteFrontEndApi.HttpClientModel
{
    public class PeopleClientResponse
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
