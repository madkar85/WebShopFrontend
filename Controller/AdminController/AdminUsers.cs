using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopFrontend.Helpers;

namespace WebShopFrontend.Controller.AdminController
{
    public class AdminUsers
    {
        public static WebShopAPI api = new WebShopAPI();

        public static void PrintUsers(int adminId)
        {
            //Skriv ut lista på användare
            UserHelpers.IsUserActice(adminId);

            var users = api.ListUser(adminId);
            Console.WriteLine("The users are: ");
            foreach (var u in users)
            {
                Console.WriteLine(u.Name);

            }

        }

        public static void SearchForUser(int adminId)
        {
            //Sök efter användare
            UserHelpers.IsUserActice(adminId);

            Console.WriteLine("Search for: ");
            string keyword = Console.ReadLine();
            var match = api.FindUser(adminId, keyword);
            Console.WriteLine("Matching results: ");
            foreach (var m in match)
            {
                Console.WriteLine(m.Name);
            }

        }

        public static void AddingUser(int adminId)
        {
            //Lägg till användare
            UserHelpers.IsUserActice(adminId);

            Console.WriteLine("What user would you like to add?");
            Console.WriteLine("Username: ");
            string name = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            var added = api.AddUser(adminId, name, password);
            //Console.WriteLine(added);

        }

    }
}
