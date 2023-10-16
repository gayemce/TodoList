using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoListWebApi.Context;
using TodoListWebApi.Dtos;
using TodoListWebApi.Models;

namespace TodoListWebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class TodosController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateToDo(CreateToDoDto request)
    {
        AppDbContext context = new();
        var checkWork = context.Todos.Any(p => p.Work == request.Work);
        if (checkWork)
        {
            return BadRequest("This is already on the to-do list.");
        }
        Todo todo = new()
        {
            Work = request.Work,
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            CompletedAt = DateTime.Now
        };

        context.Todos.Add(todo);
        context.SaveChanges();
        return Ok(todo);

    }

    [HttpGet("{id}")]
    public IActionResult RemoveToDo(int id) 
    {
        AppDbContext context = new();
        var work = context.Todos.Find(id);
        if (work == null)
        {
            return BadRequest("No such record was found.");
        }
        context.Todos.Remove(work);
        context.SaveChanges();
        return Ok(GetAll());
    }

    [HttpPost]
    public IActionResult UpdateToDo(UpdateToDoDto request)
    {
        AppDbContext context = new();
        var work = context.Todos.Find(request.Id);
        if (work == null)
        {
            return NoContent();
        }
        work.Work = request.Work;
        context.SaveChanges();
        return Ok(GetAllTodos());
    }

    [HttpGet("{id}")]
    public IActionResult ChangeCompleted(int id)
    {
        AppDbContext context = new();
        var work = context.Todos.Find(id);
        if(work == null)
        {
            return NoContent();
        }
        work.IsCompleted = !work.IsCompleted;
        work.CompletedAt = DateTime.Now;

        context.SaveChanges();
        return Ok(GetAllTodos());
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(GetAllTodos());
    }

    private List<Todo> GetAllTodos()
    {
        AppDbContext context = new();
        var todos = context.Todos.ToList();
        return todos;
    }
}
