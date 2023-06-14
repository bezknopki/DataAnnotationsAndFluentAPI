using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _9_DataTypes
{
    public class User
    {
        public int Id { get; set; }
        public int Passport { get; set; }
        public int PhoneNumber { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
