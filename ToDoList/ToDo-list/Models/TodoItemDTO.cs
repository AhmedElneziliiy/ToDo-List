using System.ComponentModel.DataAnnotations;

namespace ToDo_list.Models
{
    public class TodoItemDTO
    {
        public Guid Id { get; set; }
        [Required]

        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsCompleted { get; set; }
    }
}
