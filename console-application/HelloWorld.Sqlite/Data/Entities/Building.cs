using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Sqlite.Data.Entities
{
    public class Building : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
