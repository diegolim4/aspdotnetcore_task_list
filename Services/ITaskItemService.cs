using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services
{
    // Defindo a interface
    public interface ITaskItemService
    {
        Task<IEnumerable<TaskItem>> GetItemAsync();
    }
}   