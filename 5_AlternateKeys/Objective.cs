using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5_AlternateKeys
{
    public class Objective
    {
        public int Id { get; set; }
        public int AltKey { get; set; }
        public int PartOfKey{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
