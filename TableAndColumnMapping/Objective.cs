using System.ComponentModel.DataAnnotations.Schema;

namespace _3_TableAndColumnMapping
{
    //[Table("Tasks")]
    public class Objective
    {
        //[Column("task_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
