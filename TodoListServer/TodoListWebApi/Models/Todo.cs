namespace TodoListWebApi.Models;

public class Todo
{
    public int Id { get; set; }
    public string Work { get; set; }
    public Boolean IsCompleted { get; set; }
    public Boolean IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime CompletedDate { get; set; }
}
