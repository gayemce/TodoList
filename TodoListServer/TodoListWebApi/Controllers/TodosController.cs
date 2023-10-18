using Microsoft.AspNetCore.Mvc;
using System;
using TodoListWebApi.Context;
using TodoListWebApi.Dtos;
using TodoListWebApi.Models;

namespace TodoListWebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class TodosController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(CreateToDoDto request)
    {
        AppDbContext context = new();
        var CheckWorkIsUnique = context.Todos.Any(p => p.Work == request.Work);
        if (CheckWorkIsUnique)
        {
            return BadRequest("The record already exists");
        }

        Todo todo = new()
        {
            Work = request.Work,
            IsCompleted = false,
            IsDeleted = false,
            CreatedDate = DateTime.Now
        };

        context.Todos.Add(todo);
        context.SaveChanges();
        return Ok(todo);
    }

    [HttpPost("{id}")]
    public IActionResult Remove(int id)
    {
        AppDbContext context = new();
        var todo = context.Todos.Find(id);
        if (todo == null)
        {
            return BadRequest("No Records Found");
        }
        //todo.IsDeleted = true;
        context.Todos.Remove(todo);
        context.SaveChanges();
        return NoContent();
    }

    [HttpPost]
    public IActionResult Update(UpdateToDoDto request)
    {
        AppDbContext context = new();
        var todo = context.Todos.Find(request.Id);
        if (todo == null)
        {
            return BadRequest("No Records Found");
        }
        todo.Work = request.Work;
        context.SaveChanges();
        return NoContent();
    }

    [HttpGet("{id}")]
    public IActionResult ChangeCompleted(int id)
    {
        AppDbContext context = new();
        var todo = context.Todos.Find(id);
        if (todo == null)
        {
            return BadRequest("No Records Found");
        }
        todo.IsCompleted = !todo.IsCompleted;
        todo.CompletedDate = DateTime.Now;
        context.SaveChanges();
        return NoContent();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        AppDbContext context = new();

        var todos = context.Todos
            .OrderByDescending(o => o.CompletedDate)
            .ToList();
        return Ok(todos);
    }
}
