using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopAssignment.Helpers;
using WebShopAssignment.Models;
using WebShopFrontend.View;

namespace WebShopFrontend.Controller
{
    public class UserBook
    {
        public static WebShopAPI api = new WebShopAPI();

        public static void SearchForBook(int userId)
        {
            api.Ping(userId);

            Console.WriteLine("Sök efter: ");
            string input = Console.ReadLine();

            var book = api.GetBooks(input);
            foreach (var b in book)
            {
                Console.WriteLine($"Nr: {b.Id}. Titel: {b.Title}");
            }
            Console.WriteLine("Vilken vill du välja?");

        }

        public static void GetBooksInCategory(int choice, int userId)
        {
            var id = 0;
            var listOfBooks = api.GetCategory(choice);
            Console.WriteLine("Böcker i vald kategori: ");
            foreach (var b in listOfBooks)
            {
                Console.WriteLine($"{b.Id} {b.Title}");
            }
            Console.WriteLine("Vilket bok vill du få mer information om?");
            int input = Convert.ToInt32(Console.ReadLine());
            var book = api.GetBook(input);
            foreach (var b in book)
            {
                UserHelper.PrintAllInformation(b);
                 id = b.Id;
            }
            Console.WriteLine("Vill du köpa denna?");
            string answer = Console.ReadLine().ToLower();
            if(answer == "ja")
            {
                api.BuyBook(userId, id);
            }
            else if (answer == "nej")
            {
                UsersView.UserMenu(userId);
            }
            else
            {
                Messages.WrongInput();
            }

        }
    }
}
