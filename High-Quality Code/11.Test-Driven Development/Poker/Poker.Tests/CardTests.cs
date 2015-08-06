namespace Poker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardShouldReturnValidFaceAndSuit()
        {
            var card = new Card(CardFace.King, CardSuit.Spades);

            string expectedFaceAndSuit = "King of Spades";
            string faceAndSuit = card.ToString();

            Assert.AreEqual(expectedFaceAndSuit, faceAndSuit);
        }
    }
}