using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCard.BusinessLayer
{
   public  class Deck
    {

        public Deck()
        {
            Cards = new string[] { "Diamond Ace", "Diamond 2", "Diamond 3", "Diamond 4", "Diamond 5", "Diamond 6", "Diamond 7", "Diamond 8", "Diamond 9", "Diamond 10", "Diamond King", "Diamond Queen", "Diamond Jack" ,
                                      "Spade Ace", "Spade 2", "Spade 3", "Spade 4", "Spade 5", "Spade 6", "Spade 7", "Spade 8", "Spade 9", "Spade 10", "Spade King", "Spade Queen", "Spade Jack" ,
                                      "Heart Ace", "Heart 2", "Heart 3", "Heart 4", "Heart 5", "Heart 6", "Heart 7", "Heart 8", "Heart 9", "Heart 10", "Heart King", "Heart Queen", "Heart Jack" ,
                                      "Club Ace", "Club 2", "Club 3", "Club 4", "Club 5", "Club 6", "Club 7", "Club 8", "Club 9", "Club 10", "Club King", "Club Queen", "Club Jack"
                                    };
                
        }
        public string[] Cards { get; set; }
        public string[] PickedUpCards { get; set; }
    }
}
