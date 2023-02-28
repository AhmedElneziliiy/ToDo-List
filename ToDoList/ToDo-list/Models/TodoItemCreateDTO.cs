using System.ComponentModel.DataAnnotations;

namespace ToDo_list.Models
{
    public class TodoItemCreateDTO
    {
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsComplete { get; set; }
    }
}
