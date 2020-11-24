using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sbt.Test.Refactoring.Models;

namespace Sbt.Test.Refactoring
{
    public class GuardTower : UnitModel, Arms
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

        public GuardTower()
        {
            _position = new int[] { 0, 0 };
            _field = new int[] { 5, 5 };
            _orientation = Orientation.North;
            _ammunition = 30;
        }

        public GuardTower(int xPosition, int yPosition)
        {
            _position = new int[] { xPosition, yPosition };
            _field = new int[] { 5, 5 };
            _orientation = Orientation.North;
        }

        public override void Move(string command)
        {
            if (command == "T")
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
