using System;
using TinyCsvParser.Mapping;

namespace HelloWorld.SimpleCsvParser.Models
{
    public class UserMappingCsv : CsvMapping<User>
    {
        public UserMappingCsv() : base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.FirstName);
            MapProperty(2, x => x.LastName);
            MapProperty(3, x => x.Address);
            MapProperty(4, x => x.RegistrationDate);
            MapProperty(5, x => x.IsEnabled);
        }
    }
}
