using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sbt.Test.Refactoring.Models;

namespace Sbt.Test.Refactoring
{
    public class Wild : UnitModel
    {
        public Wild()
        {
            _position = new int[] { 0, 0 };
            _field = new int[] { 5, 5 };
            _orientation = Orientation.North;
        }

        public override void Move(string command)
        {
            if (command == "T")
            {
                _orientation = MoveList.TurnClockwise(_orientation);
            }
        }
    }
}
