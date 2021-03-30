using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopFrontend.Helpers;

namespace WebShopFrontend.Controller.AdminController
{
    public class AdminBook
    {
        public static WebShopAPI api = new WebShopAPI();
        /// <summary>
        /// anropar metoden som lägger till bok i databasen
        /// </summary>
        /// <param name="adminId"></param>
        public static void AddsBook(int adminId)
        {
            //AddBook
            UserHelpers.IsUserActice(adminId);

            Console.WriteLine("Skriv in titeln: ");
            string title = Console.ReadLine();
            Console.WriteLine("Författare: ");
            string author = Console.ReadLine();
            Console.WriteLine("Pris: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antal böcker i lager: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            var added = api.AddBook(adminId, title, author, price, amount);
            Console.WriteLine(added);
        }

        public static void SetsAmount(int adminId)
        {
            //SetAmount, lägg till antal i lager
            //Hur hittar jag bookId som ska skickas in i metod api.SetAmount
            UserHelpers.IsUserActice(adminId);



        }

        //Uppdatera bok
        //Ta bort bok som saknar antal
        //Lägg till kategori på bok som saknar det

    }
}
