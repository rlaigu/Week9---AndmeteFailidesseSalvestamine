using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileLocation = @"C:\Users\...\sample\ShoppingList";
            string fileName = @"\\shoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    shoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string wish in shoppingList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", shoppingList);


        }
    }
}
