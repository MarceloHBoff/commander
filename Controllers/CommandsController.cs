using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommanderRepository _repository;
    private readonly IMapper _mapper;

    public CommandsController(ICommanderRepository repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
    {
      var commands = _repository.GetAllCommands();

      return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
    }

    [HttpGet("{id}")]
    public ActionResult<CommandReadDto> GetCommandById(int id)
    {
      var command = _repository.GetCommandById(id);

      if (command != null)
      {
        return Ok(_mapper.Map<CommandReadDto>(command));
      }

      return NotFound();
    }

    [HttpPost]
    public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto command)
    {
      var commandModel = _mapper.Map<Command>(command);

      _repository.CreateCommand(commandModel);
      _repository.SaveChanges();

      var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

      return Ok(commandReadDto);
    }
  }
}