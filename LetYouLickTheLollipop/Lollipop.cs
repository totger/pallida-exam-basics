using System;
namespace LetYouLickTheLollipop
{
    public class Lollipop
    {
		public static int SugarToMake = 5;
		public static int Price = 10;

        public Lollipop(CandyShop candyShop)
        {
			candyShop.SugarAmount -= SugarToMake;
			candyShop.Storage[1]++;
        }
		
        public void Raise(int percent)
		{
			Price += Price * percent / 100;
		}
    }
}
