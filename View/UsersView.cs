using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;

namespace WebShopFrontend.View
{
    public class UsersView
    {
        public static WebShopAPI api = new WebShopAPI();
        public static void NewUser(string name, string password)
        {
            
            Console.WriteLine("Användaren finns inte. Vill du registrera dig?");
            Console.WriteLine("Ja/Nej: ");
            string answer = Console.ReadLine().ToLower();
            if(answer == "nej")
            {
                Console.WriteLine("Tack för besöket!");
                
            }
            else if(answer == "ja")
            {
                Console.WriteLine("Skriv lösenordet igen: ");
                string verify = Console.ReadLine();
                api.Register(name, password, verify);
            }
            else
            {
                Messages.WrongInput();
            }           
        }

        public static void UserMenu(int userId)
        {
            //skriv valen man kan göra som användare, hänvisa sedan till en metod i User-controllern som hanterar vilket val
            Console.WriteLine("Välkommen!");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Få en lista över alla kategorier");
            Console.WriteLine("2. Sök efter kategori");
            Console.WriteLine("3. Få en lista på böcker i en kategori");
            Console.WriteLine("4. Få en lista på böcker i lager");
            Console.WriteLine("5. Information om en bok");
            Console.WriteLine("6. Sök efter bok");
            Console.WriteLine("7. Sök efter böcker av en författare");
            Console.WriteLine("8. Köp bok"); //?
            Console.WriteLine("9. Logga ut");
            int choice = Convert.ToInt32(Console.ReadLine());

            Controller.UserController.UserMenu.UserChoiceOfMenu(userId, choice);
           
            //GetCategory, lista på böcker i en kategori
            //GetAvailableBooks, lista på alla böcker som finns i lager
            //GetBook, info om en specifik bok
            //GetBooks, lista på böcker som matchar sökning
            //GetAuthors, lista på böcker som matchar sökning
            //BuyBooks
            //logout
        }
    }
}
