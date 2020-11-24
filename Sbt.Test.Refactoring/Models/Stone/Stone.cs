using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sbt.Test.Refactoring.Models;

namespace Sbt.Test.Refactoring
{
    public class Stone : UnitModel
    {
        public Stone()
        {
            _position = new int[] { 0, 0 };
            _field = new int[] { 5, 5 };
            _orientation = Orientation.North;
        }
    }
}
