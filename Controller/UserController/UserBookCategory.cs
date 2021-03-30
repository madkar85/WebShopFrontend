using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;

namespace WebShopFrontend.Controller.UserController
{
    public class UserBookCategory
    {
        public static WebShopAPI api = new WebShopAPI();
        /// <summary>
        /// Skriver ut alla kategorier i databasen
        /// </summary>
        /// <param name="userId"></param>
        public static void PrintAllCategories(int userId)
        {
            api.Ping(userId);

            var cat = api.GetCategories();
            foreach(var c in cat)
            {
                Console.WriteLine($"Kategori: {c.Id}, {c.Name}");
            }
            Console.WriteLine("Vilken kategori vill du välja?");
            int choice = Convert.ToInt32(Console.ReadLine());
            UserBook.GetBooksInCategory(choice, userId);

        }

        public static void SearchForCategories(int userId)
        {
            api.Ping(userId);

            Console.WriteLine("Sök efter: ");
            string keyword = Console.ReadLine();
            var cat = api.GetCategories(keyword);
            foreach (var c in cat)
            {
                Console.WriteLine($"Resultat: {c.Name}");
            }
        }
    }
}
