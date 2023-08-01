using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace UygulamaHavuzum.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
          
        }
        public DbSet<TodoList> TodoListApp { get; set; }
    }
}
