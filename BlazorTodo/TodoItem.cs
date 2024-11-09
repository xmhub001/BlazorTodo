using Microsoft.VisualBasic;

namespace BlazorTodo
{
    public class TodoItem
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime StartDate { get; set; }
    }
}
