using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCard.BusinessLayer
{
   public class DealOneCardResponse
   {
        public DealOneCardResponse()
        { }
        public string[] RemainingCards { get; set; }
        public string[] PickedUpCards { get; set; }
        public string CardPicked { get; set; }
   }
}
