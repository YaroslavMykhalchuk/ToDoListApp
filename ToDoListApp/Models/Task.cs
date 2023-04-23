using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool IsDone { get; set; }

        public Category Category { get; set; }
    }
}