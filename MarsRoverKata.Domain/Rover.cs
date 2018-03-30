using static MarsRoverKata.Domain.Direction;

namespace MarsRoverKata.Domain
{
    public class Rover
    {
        private Direction direction = North;

        private Coordinate coordinate = new Coordinate(0, 0);
        private readonly Orientator orientator;
        private Grid grid;

        public Rover(Orientator orientator, Grid grid)
        {
            this.orientator = orientator;
            this.grid = grid;
        }

        public string Execute(string command)
        {
            foreach (var character in command)
            {
                if (character == 'R')
                {
                    direction = orientator.Right(direction);
                }

                if (character == 'L')
                {
                    direction = orientator.Left(direction);
                }

                if (character == 'M')
                {
                    coordinate = grid.NextCoordinateFor(direction, coordinate);
                }
            }
            return coordinate.X + ":" + coordinate.Y + ":" + (char)direction;
        }
    }
}