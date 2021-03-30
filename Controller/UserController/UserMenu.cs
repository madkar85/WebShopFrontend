using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopFrontend.View;

namespace WebShopFrontend.Controller.UserController
{
    public class UserMenu
    {
        public static WebShopAPI api = new WebShopAPI();
        public static void UserChoiceOfMenu(int userId, int input)
        {
            switch (input)
            {
                case 1:
                    UserBookCategory.PrintAllCategories(userId);                    
                    break;
                case 2:
                    UserBookCategory.SearchForCategories(userId);
                    //api.GetCategories();
                    break;
                case 3:
                    //api.GetCategory();
                    break;
                case 4:
                    //api.GetAvailableBooks();
                    break;
                case 5:
                   // api.GetBook();
                    break;
                case 6:
                    UserBook.SearchForBook(userId);
                    //api.GetBooks();
                    break;
                case 7:
                   // api.GetAuthors();
                    break;
                case 8:
                    //skriv ut en lista på alla böcker, fråga sedan vilken dom vill köpa. Svaret visar vilket index
                    // i listan som ska sparas, det är bookId.
                    //api.BuyBook();
                    break;
                case 9:
                   // api.Logout();
                    break;
                default:
                    Messages.WrongInput();
                    break;

            }

        }
    }
}
