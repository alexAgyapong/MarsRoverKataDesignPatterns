using System.Collections.Generic;

namespace MarsRoverKata.Domain.Commands
{
    public static class AvailableCommands
    {
        public static Dictionary<string, ICommand> AllCommands
        {
            get
            {
                var commands = new Dictionary<string, ICommand>
                {
                    {"R", new RotateRightCommand()},
                    {"L", new RotateLeftCommand()},
                    {"M", new MoveCommand()}
                };
                return commands;
            }
        }
    }
}