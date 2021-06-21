using System;

namespace Tarefas.Models
{
    public class TaskItem
    {
        public System.Guid Id { get; set; }

        public bool IsComplete { get; set; }
    
        public string Name  { get; set; }
    
        public DateTimeOffset? Dataconclusion { get; set; }
    }
}