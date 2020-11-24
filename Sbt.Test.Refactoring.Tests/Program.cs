using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            TractorTest tractorTest = new TractorTest();

            tractorTest.TestShouldMoveForward();
            tractorTest.TestShouldThrowExceptionIfFallsOffPlateau();
            tractorTest.TestShouldTurn();
            tractorTest.TestShouldTurnAndMoveInTheRightDirection();

            TankTest tankTest = new TankTest();
            tankTest.TestShouldMoveForward();
            tankTest.TestShouldThrowExceptionIfFallsOffPlateau();
            tankTest.TestShouldTurn();
            tankTest.TestShouldTurnAndMoveInTheRightDirection();
            tankTest.TestShouldMoveForwardTurnShot();

            GuardTowerTest guardTowerTest = new GuardTowerTest();
            guardTowerTest.TestShouldMoveForward();
            guardTowerTest.TestShouldTurn();
            guardTowerTest.TestShouldMoveTurnShot();

            UnitModelTest unitModelTest = new UnitModelTest();
            unitModelTest.TestShouldMoveForward();
            unitModelTest.TestShouldMoveTurn();

            Console.ReadLine();  
        }
    }
}
