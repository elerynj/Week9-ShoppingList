using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Add something to your list:");
                    string userWish = Console.ReadLine();
                    myShoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Have a nice day!");
                }
            }

            Console.Clear();

            foreach (string wish in myShoppingList)
            {
                Console.WriteLine($"Your shopping list: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
