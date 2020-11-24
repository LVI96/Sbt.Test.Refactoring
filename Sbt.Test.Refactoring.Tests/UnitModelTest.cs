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
    class UnitModelTest
    {
        [TestMethod]
        public void TestShouldMoveForward()
        {
            ArrayList unitModels = new ArrayList();

            UnitModel stone = new Stone();
            unitModels.Add(stone);

            UnitModel wild = new Wild();
            unitModels.Add(wild);

            UnitModel tractor = new Tractor();
            unitModels.Add(tractor);

            UnitModel tank = new Tank();
            unitModels.Add(tank);

            UnitModel guardTower = new GuardTower();
            unitModels.Add(guardTower);

            foreach (UnitModel unitModel in unitModels)
            {
                unitModel.Move("F");
                Console.WriteLine(unitModel.GetPositionX().ToString() + " " + unitModel.GetPositionY().ToString());
            }
            Console.WriteLine();
        }

        [TestMethod]
        public void TestShouldMoveTurn()
        {
            ArrayList unitModels = new ArrayList();

            Stone stone = new Stone();
            unitModels.Add(stone);

            Wild wild = new Wild();
            unitModels.Add(wild);

            Tractor tractor = new Tractor();
            unitModels.Add(tractor);

            Tank tank = new Tank();
            unitModels.Add(tank);

            GuardTower guardTower = new GuardTower();
            unitModels.Add(guardTower);

            foreach (UnitModel unitModel in unitModels)
            {
                unitModel.Move("T");
                Console.WriteLine(unitModel.Orientation);
            }
            Console.WriteLine();
        }

        [TestMethod]
        public void TestShouldMoveShot()
        {
            ArrayList unitModels = new ArrayList();

            Stone stone = new Stone();
            unitModels.Add(stone);

            Wild wild = new Wild();
            unitModels.Add(wild);

            Tractor tractor = new Tractor();
            unitModels.Add(tractor);

            Tank tank = new Tank();
            unitModels.Add(tank);

            GuardTower guardTower = new GuardTower();
            unitModels.Add(guardTower);

            foreach (UnitModel unitModel in unitModels)
            {
                unitModel.Move("S");
                //Console.WriteLine(unitModel.GetArmmo());
            }
            Console.WriteLine();
        }
    }
}
