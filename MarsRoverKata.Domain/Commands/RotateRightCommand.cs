using System;

namespace MarsRoverKata.Domain.Commands
{
    public class RotateRightCommand : ICommand
    {
        public void Execute(INavigator navigator, Direction direction, Coordinate coordinate)
        {
            throw new NotImplementedException();
        }
    }
}