using System.ComponentModel.DataAnnotations;


namespace BlazorTasker.Models
{
    public class TaskerItem
    { 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Must have a Name!")]
        public string Name { get; set; } = "";

        public bool IsCompleted { get; set; } = false;
    }
}
