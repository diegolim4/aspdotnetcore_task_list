using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services
{
    public class TempTaskItemService : ITaskItemService
    {
        // Implementando a interface
        public Task<IEnumerable<TaskItem>> GetItemAsync()
        {
            //Retorna um array de itens de tarefas
            IEnumerable<TaskItem> items = new[]
            {
                new TaskItem{
                    Name = " Estudar ASP.Net Core 2.0",
                    IsComplete = false,
                    Dataconclusion = DateTimeOffset.Now.AddDays(30)
                    
                },
                new TaskItem{
                    Name = " Criar aplicações Web",
                    IsComplete = false,
                    Dataconclusion = DateTimeOffset.Now.AddDays(50)
                    
                },
            };
            return Task.FromResult(items);
        }
    }
}