using System;
using System.Net.NetworkInformation;
using Microsoft.EntityFrameworkCore;

namespace SimpleToDoModels.Models;

public class SimpleToDoService : ISimpleToDoService
{
    private readonly SimpleToDoDbContext _context;

    public SimpleToDoService(SimpleToDoDbContext context)
    {
        _context = context;
    }

    public async Task Create(SimpleToDoModels model)
    {
        await _context.SimpleToDoModel.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task<SimpleToDoModels> Retrieve(int id)
    {
        var todo = await _context.SimpleToDoModel.FindAsync(id);

        if (todo == null)
        {
            throw new Exception("The ToDo does not exist");
        }

        return todo;
    }

    public async Task<List<SimpleToDoModels>> RetrieveAll()
    {
        var todo = await _context.SimpleToDoModel.ToListAsync();
        return todo;
    }

    public async Task Update(int id, SimpleToDoModels model)
    {
        var todo = await _context.SimpleToDoModel.FindAsync(id);

        if (todo is null)
        {
            throw new Exception("There is no such ToDo");
        }

        todo.Name = model.Name;
        todo.DeadLine = model.DeadLine;
        todo.IsDone = model.IsDone;

        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var todo = await _context.SimpleToDoModel.FindAsync(id);

        if (todo is null)
        {
            throw new Exception("The ToDo does not exist");
        }

        _context.SimpleToDoModel.Remove(todo);
        await _context.SaveChangesAsync();
    }
}