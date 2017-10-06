using System;
namespace LetYouLickTheLollipop
{
    public class CandyShop
    {
        public int SugarAmount;
        public int Income;
        public int[] Storage = {0, 0};

        public CandyShop(int sugar)
        {
            SugarAmount = sugar;
        }

        public void CreateSweetsCandy(CandyShop candyShop)
        {
            Candy candy = new Candy(candyShop);
        }

		public void CreateSweetsLollipop(CandyShop candyShop)
		{
            Lollipop lollipop = new Lollipop(candyShop);
		}

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2}$ Sugar: {3}gr",
                              Storage[0], Storage[1], Income, SugarAmount);
        }

        public void SellCandy(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
				Storage[0]--;
				Income += Candy.Price;
            }
        }

		public void SellLollipop(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
				Storage[1]--;
				Income += Lollipop.Price;
            }
		}

        public void BuySugar(int amount)
        {
            SugarAmount += amount;
            Income -= amount / 10;
        }
    }
}
