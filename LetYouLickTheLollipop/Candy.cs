using System;
namespace LetYouLickTheLollipop
{
    public class Candy 
    {
        public static int SugarToMake = 10;
        public static int Price = 20;

        public Candy(CandyShop candyShop)
        {
            candyShop.SugarAmount -= SugarToMake;
            candyShop.Storage[0]++;
        }

        public void Raise(int percent)
        {
            Price += Price * percent / 100;
        }
    }
}
