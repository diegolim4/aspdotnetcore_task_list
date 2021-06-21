using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {   
            var tasks = _taskService.GetItemAsync();            
            return View(tasks);
        }
    }
}