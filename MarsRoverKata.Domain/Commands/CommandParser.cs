using System.Collections.Generic;

namespace MarsRoverKata.Domain.Commands
{
    public class CommandParser
    {
        private Dictionary<string, ICommand> availableCommands;

        public CommandParser(Dictionary<string, ICommand> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        public ICommand ParseCommand(string commandString)
        {
            if (availableCommands.ContainsKey(commandString))
            {
                return availableCommands[commandString];
            }

            return null;
        }
    }
}