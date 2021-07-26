using System.Collections.Generic;
using System.Linq;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<Parson> people = new();

        public DemoDataAccess()
        {
            people.Add(new Parson { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new Parson { Id = 1, FirstName = "Sue", LastName = "Storm" });
        }

        public List<Parson> GetPeople()
        {
            return people;
        }

        public Parson InsertParson(string firstaName, string lastName)
        {
            Parson p = new() { FirstName = firstaName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}