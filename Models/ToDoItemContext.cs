using Microsoft.EntityFrameworkCore;
namespace lesson8_handson_aspnet.Models
{
    public class ToDoItemContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}