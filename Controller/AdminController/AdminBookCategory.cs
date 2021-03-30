using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopFrontend.Helpers;

namespace WebShopFrontend.Controller.AdminController
{
    public class AdminBookCategory
    {
        public static WebShopAPI api = new WebShopAPI();

        //Lägg till en kategori
        public static void AddsCategory(int adminId)
        {
            UserHelpers.IsUserActice(adminId);

            Console.WriteLine("Vad är namnet på kategorin?: ");
            string categoryName = Console.ReadLine();

            api.AddCategory(adminId, categoryName);

        }
        //Uppdatera kategori
        //Ta bort kategori som saknar böcker

    }
}
