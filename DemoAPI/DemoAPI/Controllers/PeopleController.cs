using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//https://www.youtube.com/watch?v=vN9NRqv7xmY
namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController() {
            people.Add(new Person {Id = 1, FirstName = "Joey", LastName = "Tribianni" });
            people.Add(new Person { Id = 2, FirstName = "Chandler", LastName = "Bing" });
            people.Add(new Person { Id = 3, FirstName = "Bilbo", LastName = "Baggins" });
        }

        //create inline custom route and api method
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames() {
            List<string> output = new List<string>();
            foreach (var p in people) {
                output.Add(p.FirstName);
            }
            return output;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        //when using postman, if no error then success
        //from body tab, make text format to JSON to success
        //use breakpoint in this Post method to check if data input in body tab of postman appp was passed here
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
