using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleShip;
using SwinGameSDK;
namespace BattleShipUnitTests
{
    [TestClass]
    public class AttackResultUnitTests
    {
        [TestMethod]
        public void ToStringFunction()
        {
            Ship _ship = new Ship(ShipName.Battleship);
            AttackResult att = new AttackResult(ResultOfAttack.Hit,_ship, "hello", 100,200);
            string expected = "hello Battleship";
            string actual = att.ToString();

            Assert.AreEqual(expected,actual,"correct answer is hello Battleship");

        }
        [TestMethod]
        public void ShipPropertyFunction()
        {
            Ship ship1 = new Ship(ShipName.AircraftCarrier);
            AttackResult att = new AttackResult(ResultOfAttack.Miss, ship1, "hello", 100, 200);
            Ship ship2 = new Ship(ShipName.AircraftCarrier);
            string expected = ship2.Name;
            string actual = att.Ship.Name;

            Assert.AreEqual(expected, actual, "the name should be the same");
        }
    }
}
