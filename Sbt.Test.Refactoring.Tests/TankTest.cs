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
    class TankTest
    {
        [TestMethod]
        public void TestShouldMoveForward()
        {
            Tank tank = new Tank();

            tank.Move("F");
            Assert.AreEqual(0, tank.GetPositionX());
            Assert.AreEqual(1, tank.GetPositionY());
        }

        [TestMethod]
        public void TestShouldTurn()
        {
            Tank tank = new Tank();

            tank.Move("T");
            Assert.AreEqual(Orientation.East, tank.Orientation);

            tank.Move("T");
            Assert.AreEqual(Orientation.South, tank.Orientation);

            tank.Move("T");
            Assert.AreEqual(Orientation.West, tank.Orientation);

            tank.Move("T");
            Assert.AreEqual(Orientation.North, tank.Orientation);
        }

        [TestMethod]
        public void TestShouldTurnAndMoveInTheRightDirection()
        {
            Tank tank = new Tank();

            tank.Move("T");
            tank.Move("F");
            Assert.AreEqual(1, tank.GetPositionX());
            Assert.AreEqual(0, tank.GetPositionY());

            tank.Move("T");
            tank.Move("F");
            Assert.AreEqual(1, tank.GetPositionX());
            Assert.AreEqual(-1, tank.GetPositionY());

            tank.Move("T");
            tank.Move("F");
            Assert.AreEqual(0, tank.GetPositionX());
            Assert.AreEqual(-1, tank.GetPositionY());

            tank.Move("T");
            tank.Move("F");
            Assert.AreEqual(0, tank.GetPositionX());
            Assert.AreEqual(0, tank.GetPositionY());
        }

        [TestMethod]
        public void TestShouldMoveForwardTurnShot()
        {
            Tank tank = new Tank();

            tank.Move("F");
            Assert.AreEqual(0, tank.GetPositionX());
            Assert.AreEqual(1, tank.GetPositionY());

            tank.Move("T");
            Assert.AreEqual(Orientation.East, tank.Orientation);

            tank.Move("S");
            Assert.AreEqual(14, tank.Ammunition);
        }

        [TestMethod]
        public void TestShouldThrowExceptionIfFallsOffPlateau()
        {
            Tank tank = new Tank();

            tank.Move("F");
            tank.Move("F");
            tank.Move("F");
            tank.Move("F");
            tank.Move("F");

            try
            {
                tank.Move("F");
                Assert.Fail("Tank was expected to fall off the plateau");
            }
            catch (UnitInDitchException ex)
            {
            }
        }
    }
}
