using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleShip;
using SwinGameSDK;
namespace BattleShipUnitTests
{
    [TestClass]
    public class TileUnitTests
    {
        [TestMethod]
        
        public void ClearShipFunction()
        {
            Ship ship1 = new Ship(ShipName.Destroyer);
            Tile tile = new Tile(10, 20, ship1);

            Ship expected = null;
            tile.ClearShip();

            Ship actual = tile.Ship;

            Assert.AreEqual(expected, actual, "should be null");
        }
    }
}
