namespace MarsRoverKata.Domain.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(INavigator navigator, Direction direction, Coordinate coordinate)
        {
            navigator.NextCoordinateFor(direction, coordinate);
        }
    }
}