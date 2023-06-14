using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _8_LengthRestrictions
{
    public class User
    {
        public int Id { get; set; }
        public int Passport { get; set; }
        public int PhoneNumber { get; set; }
        //[MaxLength(50), MinLength(5)]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
