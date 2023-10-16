namespace TodoListWebApi.Models;

public class Todo
{
    public int Id { get; set; }
    public string Work { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime CompletedAt { get; set; }
}
