using System.Collections.Generic;
using System.Linq;

namespace MarsRoverKata.Domain.Commands
{
    public class RotateCommand
    {
        public Direction Calculate(List<Direction> rotations, Direction orientation)
        {
            var newOrientationIndex = 0;
            var currentOrientationIndex = rotations.FindIndex(
                or => or == orientation
            );

            var currentOrientationAtTheEndOfList =
                currentOrientationIndex == rotations.Count - 1;

            if (!currentOrientationAtTheEndOfList)
            {
                newOrientationIndex = currentOrientationIndex + 1;
            }

            return rotations.ElementAt(newOrientationIndex);
        }
    }
}