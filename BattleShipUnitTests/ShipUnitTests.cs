using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleShip;
using SwinGameSDK;
namespace BattleShipUnitTests
{
    [TestClass]
    public class ShipUnitTests
    {
        [TestMethod]
        public void AddTileFunction()
        {
            Ship ship1 = new Ship(ShipName.Submarine);
            Tile tile = new Tile(100, 200, ship1);
            Ship expected = ship1;
            ship1.AddTile(tile);
            Ship actual = tile.Ship;

            Assert.AreEqual(expected, actual, "the ship must be the same");
        }
        [TestMethod]
        public void RemoveTileFunction()
        {
            Ship ship1 = new Ship(ShipName.Submarine);
            Tile tile = new Tile(100, 200, ship1);

            Ship expected = null;
            ship1.AddTile(tile);

            ship1.Remove();
            Ship actual = tile.Ship;

            Assert.AreEqual(expected, actual, "list of ship in tile must be null");
        }

        [TestMethod]
        public void HitFunction()
        {
            Ship ship1 = new Ship(ShipName.AircraftCarrier);
            int expected = 5;
            for (int i=0;i<5;i++)
            {
                ship1.Hit();
            }
            int actual = ship1.Hits;

            Assert.AreEqual(expected, actual, "the correct value is 5");
        }
    }
}
