namespace Poker.Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestHandShouldReturnCardsWithCommaBetween()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);

            Assert.AreEqual(string.Join(", ", cards), hand.ToString());
        }
    }
}