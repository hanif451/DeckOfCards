using DeckOfCard.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
namespace DeckOfCards.UnitTest
{
    [TestClass]
    public class PokerCardUnitTest
    {
        [TestMethod]
        public void TestPokerCard()
        {
            //try
            //{
                PokerCard pc = new PokerCard();
                pc.Shuffle();
                var response = pc.DealOneCard();
                Assert.IsTrue(!string.IsNullOrEmpty(response.CardPicked));
                while (response.RemainingCards.Length > 0)
                {
                    response = pc.DealOneCard();
                    Assert.IsTrue(response.RemainingCards.Where(x => x == response.CardPicked).Count()==0);
                }
                Assert.IsTrue(response.PickedUpCards.Length == 52);
                Assert.IsTrue(response.RemainingCards.Length == 0);

            //}
            //catch(Exception ex)
            //{
            //    string message = ex.Message;
            //}

        }
    }
}
