using System;
using System.Linq;

namespace DeckOfCard.BusinessLayer
{
    public class PokerCard
    {
        public PokerCard()
        {
            CardsObj = new Deck();
        }
        private Deck CardsObj { get; }
        public void Shuffle()
        {
            CardsObj.Cards= CardsObj.Cards.OrderBy(x => Guid.NewGuid()).ToArray();
        }
        public DealOneCardResponse DealOneCard()
        {
            DealOneCardResponse response  =new DealOneCardResponse();
            if (CardsObj != null && CardsObj.Cards != null && CardsObj.Cards.Length > 0)
            {
                response.CardPicked = CardsObj.Cards[0];
                CardsObj.Cards = CardsObj.Cards.Where(x => x != CardsObj.Cards[0]).ToArray();
                response.RemainingCards = CardsObj.Cards;
                if (CardsObj.PickedUpCards == null)
                    CardsObj.PickedUpCards = new string[52];
                CardsObj.PickedUpCards[52 - response.RemainingCards.Length - 1] = response.CardPicked;
                response.PickedUpCards = CardsObj.PickedUpCards;
               

            }
            else if(CardsObj.Cards!=null && CardsObj.PickedUpCards!=null)
            {
                response.PickedUpCards = CardsObj.PickedUpCards;
            }
            return response;
        }
    }

}
