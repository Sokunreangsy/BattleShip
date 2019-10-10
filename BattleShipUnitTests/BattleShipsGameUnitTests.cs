using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleShip;
using SwinGameSDK;
namespace BattleShipUnitTests
{
    [TestClass]
    public class BattleShipsGameUnitTests
    {
        [TestMethod]
        public void adddeployedPlayer()
        {
            BattleShipsGame game = new BattleShipsGame();
            Player ply1 = new Player(game);
            Player ply2 = new Player(game);

            game.AddDeployedPlayer(ply1);
            game.AddDeployedPlayer(ply2);

            Player expected = ply1;
            Player actual = game.Player;

            Assert.AreEqual(expected, actual);

        }
    }
}
