using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_ConfiguringKeys
{
    public class Objective
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
