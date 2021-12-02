using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins: ");
            double response = Convert.ToDouble(Console.ReadLine());

            double goldValue = response / 10;
            double actualGoldCoins = Math.Floor(response / 10);
            double remainder = response % 10;

            double silverValue = remainder / 5;
            double actualSilverCoins = Math.Floor(remainder / 5);
            double remainder2 = remainder % 5;

            Console.WriteLine($"{response} cents is equal to ...");
            Console.WriteLine($"Gold coins: {actualGoldCoins}");
            Console.WriteLine($"Silver coins: {actualSilverCoins}");
            Console.WriteLine($"Bronse coins: {remainder2}");
        }
    }
}
