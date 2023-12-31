﻿using Microsoft.EntityFrameworkCore;
using TodoListWebApi.Models;

namespace TodoListWebApi.Context;

public sealed class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-I7G56NT\\SQLEXPRESS;Initial Catalog=TodoListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Todo> Todos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>().HasData(
            new Todo { Id = 1, Work = "Get to work", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 2, Work = "Pick up groceries", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 3, Work = "Go home", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 4, Work = "Fall asleep", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 5, Work = "Get Up", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 6, Work = "Brush teeth", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 7, Work = "Take a shower", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 8, Work = "Check e-mail", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now },
            new Todo { Id = 9, Work = "Walk dog", IsCompleted = false, IsDeleted = false, CreatedDate = DateTime.Now, CompletedDate = DateTime.Now }
            );
    }
}
