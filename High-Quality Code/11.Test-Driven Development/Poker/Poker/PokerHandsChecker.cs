namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count > 5)
            {
                return false;
            }

            if (!this.AreCardsDifferent(hand))
            {
                return false;
            }

            return true;
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid");
            }

            if (this.CheckForCardsWithSameSuit(hand))
            {
                return true;
            }

            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid");
            }

            var cards = hand.Cards;

            for (int i = 0; i < cards.Count; i++)
            {
                if (cards.Count(c => c.Face == cards[i].Face) == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid");
            }

            var cards = hand.Cards;

            for (int i = 0; i < cards.Count; i++)
            {
                if (cards.Count(c => c.Face == cards[i].Face) == 3)
                {
                    return true;
                }
            }

            return false;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        private bool AreCardsDifferent(IHand hand)
        {
            var cards = hand.Cards;
            var checkedCards = new List<ICard>();

            checkedCards.Add(cards[0]);

            for (int i = 1; i < cards.Count; i++)
            {
                for (int j = 0; j < checkedCards.Count; j++)
                {
                    if (cards[i].Face == checkedCards[j].Face && cards[i].Suit == checkedCards[j].Suit)
                    {
                        return false;
                    }
                }

                checkedCards.Add(cards[i]);
            }

            return true;
        }

        private bool CheckForCardsWithSameSuit(IHand hand)
        {
            return hand.Cards[0].Suit == hand.Cards[1].Suit &&
                hand.Cards[0].Suit == hand.Cards[2].Suit &&
                hand.Cards[0].Suit == hand.Cards[3].Suit &&
                hand.Cards[0].Suit == hand.Cards[4].Suit;
        }
    }
}