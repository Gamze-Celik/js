using System.ComponentModel.DataAnnotations;

namespace UygulamaHavuzum.Models
{
    public class TodoList
    {
        [Key]
        public int Id { get; set; }
        public string? TodoListItem { get; set; }
        public bool IsDone { get; set; }


    }
}
