using System.ComponentModel.DataAnnotations.Schema;

namespace _2_ModelProperties
{
    public class Objective
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public string DevProp { get; set; }
    }
}
