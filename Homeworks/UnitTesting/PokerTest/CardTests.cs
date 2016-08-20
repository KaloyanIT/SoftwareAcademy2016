using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CheckEqualityOfTwoEqualCards()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var card2 = new Card(CardFace.Ace, CardSuit.Clubs);
            var isTrue = card.Face == card2.Face && card.Suit == card2.Suit;

            Assert.IsTrue(isTrue);
        }
        [TestMethod]
        public void CheckTwoDifferentCardsIfReturnFalse()
        {
            var card = new Card(CardFace.Five, CardSuit.Hearts);
            var card2 = new Card(CardFace.Ace, CardSuit.Clubs);
            var isTrue = card.Face == card2.Face && card.Suit == card2.Suit;


            Assert.IsFalse(isTrue);
        }

        [TestMethod]
        public void CheckIfTheToStringOverrideIsCorrect()
        {
            var card = new Card(CardFace.Five, CardSuit.Hearts);

            string correctValue = $"Card face: {card.Face} Card Suit: {card.Suit}";

            Assert.AreEqual(card.ToString(), correctValue);
        }

    }
}
