﻿namespace ToDo_list.Models
{
    public class TodoItemUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
