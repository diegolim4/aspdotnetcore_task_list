
using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Controllers
{
    public class TasksController : Controller
    {
        //método actions index para retorna lista de tarefas
        public IActionResult Index()
        {
            return View();
        }
    }
}