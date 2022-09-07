﻿using GriffonCMS.Infrastructure.Command.Projects;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase
{
    private IMediator _mediator;


    public ProjectController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    [HttpPost]
    public async Task<IActionResult> Post(CreateProjectCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteProjectByIdCommand { Id = id }));
    }
}
