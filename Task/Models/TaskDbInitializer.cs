using System;
using System.Data.Entity;

namespace Task.Models
{
    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            
        }
    }
}