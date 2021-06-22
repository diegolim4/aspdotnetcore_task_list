using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers
{
    public class TasksController : Controller
    {
        ITaskItemService _taskService;

        //Aplicando a injeção de dependência
        public TasksController(ITaskItemService taskService)
        {
            _taskService = taskService;
            
        }


        //método actions index para retorna lista de tarefas
        public async Task<IActionResult> Index()
        {   
            var tasks = await _taskService.GetItemAsync();

            var model = new TaskViewModel();            
            {
                model.TasksItens = tasks;
            }
            return View(model);
        }
    }
}