using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sbt.Test.Refactoring.Models;

namespace Sbt.Test.Refactoring
{
    public class Tank : UnitModel, Arms
    {
        int _ammunition;

        public int Ammunition
        {
            get
            {
                return _ammunition;
            }
            set 
            {
                _ammunition = value;
            }
        }

        public Tank()
        {
            _position = new int[] { 0, 0 };
            _field = new int[] { 5, 5 };
            _orientation = Orientation.North;
            _ammunition = 15;
        }

        public override void Move(string command)
        {
            if (command == "F")
            {
                var position = MoveList.Forwards(_orientation, _position, _field);
                _position[0] = position._positionX;
                _position[1] = position._positionY;
            }
            else if (command == "T")
            {
                _orientation = MoveList.TurnClockwise(_orientation);
            }
            else if (command == "S")
            {
                _ammunition = MoveList.Shot(_ammunition);
            }
        }
    }
}
