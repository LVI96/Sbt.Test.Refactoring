using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sbt.Test.Refactoring.Models;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    class GuardTowerTest
    {
        [TestMethod]
        public void TestShouldMoveForward()
        {
            GuardTower guardTower = new GuardTower();

            guardTower.Move("F");
            Assert.AreEqual(0, guardTower.GetPositionX());
            Assert.AreEqual(0, guardTower.GetPositionY());
        }

        [TestMethod]
        public void TestShouldTurn()
        {
            GuardTower guardTower = new GuardTower();

            guardTower.Move("T");
            Assert.AreEqual(Orientation.East, guardTower.Orientation);

            guardTower.Move("T");
            Assert.AreEqual(Orientation.South, guardTower.Orientation);

            guardTower.Move("T");
            Assert.AreEqual(Orientation.West, guardTower.Orientation);

            guardTower.Move("T");
            Assert.AreEqual(Orientation.North, guardTower.Orientation);
        }

        [TestMethod]
        public void TestShouldMoveTurnShot()
        {
            GuardTower guardTower = new GuardTower();

            guardTower.Move("T");
            Assert.AreEqual(Orientation.East, guardTower.Orientation);

            guardTower.Move("S");
            Assert.AreEqual(29, guardTower.Ammunition);
        }
    }
}
