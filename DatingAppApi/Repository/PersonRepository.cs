
using DatingAppApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace DatingAppApi
{
    public class PersonRepository
    {
        private static IDictionary<int, Person> dicPerson = new Dictionary<int, Person>();

        static PersonRepository()
        {
            dicPerson.Add(1000, new Person { Id = 1000, Name = "Tom" });
            dicPerson.Add(2000, new Person { Id = 2000, Name = "Chris" });
        }

        public static IEnumerable<Person> ListPerson()
        {
            return dicPerson.Values.AsEnumerable();
        }

        public static Person GetPerson(int id)
        {
            if(!dicPerson.ContainsKey(id))
                return new Person();
            
            return dicPerson[id];
        }
    }
}