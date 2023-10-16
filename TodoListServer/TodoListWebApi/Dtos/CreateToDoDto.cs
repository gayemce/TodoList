using System.ComponentModel.DataAnnotations;

namespace TodoListWebApi.Dtos;

public sealed record CreateToDoDto(
    string Work);
