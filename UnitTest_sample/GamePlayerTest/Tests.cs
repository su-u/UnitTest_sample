using System;
using NUnit.Framework;
using UnitTest_sample;

namespace GamePlayerTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PlayTimeTest()
        {
            var player = new GamePlayer("test");
            player.AddPlayTime(10);
            Assert.AreEqual(player.TotalPlayTime, 10);
        }
    }
}