using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepository : ICommanderRepository
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command> {
        new Command { Id = 0, HowTo = "", Line = "", Platform = "" },
        new Command { Id = 1, HowTo = "", Line = "", Platform = "" },
        new Command { Id = 2, HowTo = "", Line = "", Platform = "" }
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command { Id = 0, HowTo = "", Line = "", Platform = "" };
    }
  }
}