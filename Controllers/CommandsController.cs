using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommanderRepository _repository;

    public CommandsController(ICommanderRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commands = _repository.GetAllCommands();

      return Ok(commands);
    }

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      var command = _repository.GetCommandById(id);

      return Ok(command);
    }
  }
}