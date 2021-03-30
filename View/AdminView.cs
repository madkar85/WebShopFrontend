using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopFrontend.Controller;

namespace WebShopFrontend.View
{
    public class AdminView
    {
        public static WebShopAPI api = new WebShopAPI();
        public static void AdminMenu(int adminId)
        {
            Console.WriteLine("Administratörsmeny");

            Console.WriteLine("Välkommen!");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Lägg till en bok");
            Console.WriteLine("2. Lägg till antal böcker i lager");
            Console.WriteLine("3. Få en lista på användare");
            Console.WriteLine("4. Sök efter användare");
            Console.WriteLine("5. Uppdatera informationen om en bok");
            Console.WriteLine("6. Ta bort bok");
            Console.WriteLine("7. Lägg till kategori");
            Console.WriteLine("8. Lägg till kategori på bok som saknar det");
            Console.WriteLine("9. Uppdatera kategori");
            Console.WriteLine("10. Ta bort kategori utan användare");
            Console.WriteLine("11. Lägg till användare");

            int input = Convert.ToInt32(Console.ReadLine());

            Controller.AdminMenu.AdminChoiceOfMenu(input, adminId);
                       
        }
    }
}
