using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        private PokerHandsChecker checker;

        [TestInitialize]
        public void Initialize()
        {
            this.checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void TestIsValidHandShouldReturnFalseWhenThereAreMoreThan5Cards()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);

            bool isValid = this.checker.IsValidHand(hand);

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestIsValidHandShouldReturnFalseWhenThereAreDuplicatedCards()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            bool isValid = this.checker.IsValidHand(hand);

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestIsValidHandShouldReturnTrueWhenThereAre5DifferentCards()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            bool isValid = this.checker.IsValidHand(hand);

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsFlushShouldThrowWhenHandIsNotValid()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);

            bool isFlush = this.checker.IsFlush(hand);
        }

        [TestMethod]
        public void TestIsFlushShouldReturnFalseWhenThereIsCardWithDifferentSuit()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            bool isFlush = this.checker.IsFlush(hand);

            Assert.IsFalse(isFlush);
        }

        [TestMethod]
        public void TestIsFlushShouldReturnTrueWhenAllCardsAreWithSameSuit()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
            };

            var hand = new Hand(cards);

            bool isFlush = this.checker.IsFlush(hand);

            Assert.IsTrue(isFlush);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsFourOfAKindShouldThrowWhenHandIsNotValid()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);

            bool isFourOfAKind = this.checker.IsFourOfAKind(hand);
        }

        [TestMethod]
        public void TestIsFourOfAKindShouldReturnFalseWhenThereAreLessThanFourSameCardFaces()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            bool isFourOfAKind = this.checker.IsFourOfAKind(hand);

            Assert.IsFalse(isFourOfAKind);
        }

        [TestMethod]
        public void TestIsFourOfAKindShouldReturnTrueWhenThereAreFourCardsWithSameFace()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            bool isFourOfAKind = this.checker.IsFourOfAKind(hand);

            Assert.IsTrue(isFourOfAKind);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsThreeOfAKindShouldThrowWhenHandIsNotValid()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);

            bool isThreeOfAKind = this.checker.IsThreeOfAKind(hand);
        }

        [TestMethod]
        public void TestIsThreeOfAKindShouldReturnFalseWhenThereAreLessOrMoreThanThreeSameCardFaces()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            bool isThreeOfAKind = this.checker.IsThreeOfAKind(hand);

            Assert.IsFalse(isThreeOfAKind);
        }

        [TestMethod]
        public void TestIsThreeOfAKindShouldReturnTrueWhenThereAreThreeCardsWithSameFace()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
            };

            var hand = new Hand(cards);

            bool isThreeOfAKind = this.checker.IsThreeOfAKind(hand);

            Assert.IsTrue(isThreeOfAKind);
        }
    }
}