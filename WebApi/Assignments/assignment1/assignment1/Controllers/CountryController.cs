using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using assignment1.Models;

namespace assignment1.Controllers
{
    public class CountryController : ApiController
    {
        List<Country> countries = new List<Country>()
        {
            new Country{Country_ID=1,Country_Name="India",Capital="New Delhi"},
            new Country{Country_ID=2,Country_Name="USA",Capital="Washington DC"},
            new Country{Country_ID=3,Country_Name="Japan",Capital="Tokyo"},
            new Country{Country_ID=4,Country_Name="Thailand",Capital="Bangkok"}
        };

        [HttpGet]
        public IEnumerable<Country> ShowAllCountries()
        {
            return countries;
        }

        [HttpPost]
        public IEnumerable<Country> Create([FromUri]int id,string name,string capital)
        {
            Country country = new Country { Country_ID = id, Country_Name = name, Capital = capital };
            countries.Add(country);
            return countries;
        }

        [HttpPut]
        public IEnumerable<Country> Update(int id, [FromUri] int cid,string name,string capital)
        {
            Country c = new Country { Country_ID = cid, Country_Name = name, Capital = capital };
            countries[id - 1] = c;
            return countries;
        }

        [HttpDelete]
        public IEnumerable<Country> Delete(int id)
        {            
            countries.RemoveAt(id-1);
            return countries;
        }            
    }
}
