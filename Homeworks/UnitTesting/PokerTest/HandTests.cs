using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using NUnit;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PokerTest
{
    [TestFixture, Explicit]
    public class HandTests
    {
        [Test]
        public void TestToStringMethodsOfHandClassIfReturnCorrectValue()
        {
            var correctString = new StringBuilder();
            var cardList = new List<ICard>();
            for (int i = 0; i < Hand.CardsInHand; i++)
            {
                var card = new Card(CardFace.Ace, CardSuit.Clubs);
                correctString.AppendLine(card.ToString());
                cardList.Add((ICard)card);
            }
            var handOfCardsString = correctString.ToString();
            var hand = new Hand(cardList);

            Assert.IsTrue(handOfCardsString == hand.ToString());
        }

        //[Test]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void TheHandShoudNotReturnNullValue()
        //{
            
        //}
        
    }
}
