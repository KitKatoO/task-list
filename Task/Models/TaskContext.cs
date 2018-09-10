using System.Data.Entity;

namespace Task.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext()
        {
            Database.SetInitializer(new TaskDbInitializer());
        }

        public DbSet<Task> Tasks { get; set; }
    }
}