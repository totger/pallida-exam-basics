using System;

namespace LetYouLickTheLollipop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			CandyShop candyShop = new CandyShop(300);
            candyShop.CreateSweetsCandy(candyShop);
            candyShop.CreateSweetsLollipop(candyShop);
			candyShop.CreateSweetsCandy(candyShop);
			candyShop.CreateSweetsLollipop(candyShop);
            candyShop.PrintInfo();

            candyShop.SellCandy(1);
            candyShop.SellLollipop(2);

            candyShop.PrintInfo();
        }
    }
}
