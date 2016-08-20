using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Poker
{
    public class Hand : IHand
    {
        private IList<ICard> cards = new List<ICard>();
        public const int CardsInHand = 5;

        public Hand(IList<ICard> cards)
        {
            this.cards = cards;
        }

        public IList<ICard> Cards
        {
            get
            {
                return this.cards;
            }
            private set
            {
                if (value == null || value.Count != CardsInHand)
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public bool CheckIfAllCardsAreFromTheSameSuit()
        {
            for (int i = 0; i < Hand.CardsInHand - 1; i++)
            {
                if (this.cards[i].Suit != this.cards[i + 1].Suit)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < this.Cards.Count; i++)
            {
                stringBuilder.AppendLine(this.Cards[i].ToString());
            }
            return stringBuilder.ToString();
        }


    }
}
