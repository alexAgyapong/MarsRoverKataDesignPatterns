namespace MarsRoverKata.Domain
{
    public interface INavigator
    {
        Coordinate NextCoordinateFor(Direction direction, Coordinate coordinate);
    }
}