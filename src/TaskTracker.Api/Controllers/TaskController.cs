using MediatR;

using Microsoft.AspNetCore.Mvc;

using TaskTracker.Application.Commands.AddTasks;
using TaskTracker.Application.Commands.MarkTaskAsDone;
using TaskTracker.Application.Commands.RemoveTasks;
using TaskTracker.Application.Queries.GetAllTasks;
using TaskTracker.Application.Queries.GetOneTask.cs;
using TaskTracker.Domain.Entities;

namespace TaskTracker.Api.Controllers;

[ApiController]
[Route("task-tracker/api/")]
public class TaskController(IMediator mediator) : ControllerBase
{
    private readonly ISender _mediator = mediator;

    [HttpGet("tasks")]
    public async Task<IActionResult> GetAllTasks()
    {
        IEnumerable<TaskItem> tasks = await _mediator.Send(new GetAllTasksQuery());
        return Ok(tasks);
    }

    [HttpGet("tasks/{id}")]
    public async Task<IActionResult> GetOneTask(int id)
    {
        TaskItem task = await _mediator.Send(new GetOneTaskQuery(id));
        return Ok(task);
    }

    [HttpPost("tasks")]
    public async Task<IActionResult> AddTask(TaskItem taskItem)
    {
        _ = await _mediator.Send(new AddTaskCommand(taskItem));
        return StatusCode(StatusCodes.Status201Created, "Task was added successfully");
    }

    [HttpDelete("tasks/{id}")]
    public async Task<IActionResult> RemoveTask(int id)
    {
        _ = await _mediator.Send(new RemoveTaskCommand(id));
        return Ok("Task was removed successfully");
    }

    [HttpPut("tasks/{id}/done")]
    public async Task<IActionResult> MarkTaskAsDone(int id)
    {
        TaskItem task = await _mediator.Send(new MarkTaskAsDoneCommand(id));
        return Ok("Task was marked as done successfully");
    }
}