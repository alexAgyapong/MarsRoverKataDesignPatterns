namespace MarsRoverKata.Domain.Commands
{
    public interface ICommand
    {
        void Execute(INavigator navigator, Direction direction, Coordinate coordinate);
    }
}