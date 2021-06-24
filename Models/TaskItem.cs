using System;
using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Tarefa Completa")]
        public bool IsComplete { get; set; }
        [Required(ErrorMessage ="Nome da tarefa é Obrigatório")]
        [StringLength(200)]
        public string Name  { get; set; }
        [Display(Name="Data de Conclusão")]
        public DateTimeOffset? Dataconclusion { get; set; }
    }
}