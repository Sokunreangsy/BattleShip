using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BattleShip;
using SwinGameSDK;
namespace BattleShipUnitTests
{
    [TestClass]
    public class SeaGridUnitTests
    {
        [TestMethod]
        public void AlldeployedProperty()
        {
            Ship ship1 = new Ship(ShipName.Battleship);

            Dictionary<ShipName, Ship> ships = new Dictionary<ShipName, Ship> { [ShipName.Battleship] = ship1 };
            SeaGrid seagrid = new SeaGrid(ships);
            
            bool expected = false;

            bool actual = seagrid.AllDeployed;

            Assert.AreEqual(expected, actual, "correct value is false");

        }
    }
}
