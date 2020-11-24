using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public static class MoveList
    {
        public static Orientation TurnClockwise(Orientation orientation)
        {
            Orientation _orientation = orientation;

            if (orientation == Orientation.North)
            {
                _orientation = Orientation.East;
            }
            else if (orientation == Orientation.East)
            {
                _orientation = Orientation.South;
            }
            else if (orientation == Orientation.South)
            {
                _orientation = Orientation.West;
            }
            else if (orientation == Orientation.West)
            {
                _orientation = Orientation.North;
            }

            return _orientation;
        }

        public static (int _positionX, int _positionY) Forwards(Orientation orientation, int[] position, int[] field)
        {
            int[] _position = position;

            if (orientation == Orientation.North)
            {
                _position = new int[] { position[0], position[1] + 1 };
            }
            else if (orientation == Orientation.East)
            {
                _position = new int[] { position[0] + 1, position[1] };
            }
            else if (orientation == Orientation.South)
            {
                _position = new int[] { position[0], position[1] - 1 };
            }
            else if (orientation == Orientation.West)
            {
                _position = new int[] { position[0] - 1, position[1] };
            }

            if (_position[0] > field[0] || _position[1] > field[1])
            {
                throw new UnitInDitchException();
            }

            return (_position[0], _position[1]);
        }

        public static int Shot(int ammoStock)
        {
            int _ammoStock = ammoStock;

            if(ammoStock > 0)
            {
                _ammoStock--;
            }

            return _ammoStock;
        }
    }
}
