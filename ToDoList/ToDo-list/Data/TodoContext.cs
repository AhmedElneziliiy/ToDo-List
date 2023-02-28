using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDo_list.Models;

namespace ToDo_list.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}