using System.Collections.Generic;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<Parson> GetPeople();
        Parson InsertParson(string firstaName, string lastName);
    }
}