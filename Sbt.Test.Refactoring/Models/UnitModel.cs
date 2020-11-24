using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring.Models
{
    public class UnitModel
    {
        public int[] _position;

        public int[] _field;

        public Orientation _orientation;

        public Orientation Orientation
        {
            get
            {
                return _orientation;
            }
        }

        public virtual void Move(string command) { }

        public int GetPositionX()
        {
            return _position[0];
        }

        public int GetPositionY()
        {
            return _position[1];
        }
    }
}
