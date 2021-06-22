using System.Collections.Generic;

namespace Tarefas.Models
{
    public class TaskViewModel
    {
        // Nessa classe vamos exibir as informações que queremos na view(A nossa coleção de tarefas).

        public IEnumerable<TaskItem> TaskItens { get; set;}
        public IEnumerable<TaskItem> TasksItens { get; set; }
    }
}