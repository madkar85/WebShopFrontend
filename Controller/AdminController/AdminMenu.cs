using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopFrontend.Controller.AdminController;
using WebShopFrontend.View;

namespace WebShopFrontend.Controller
{
    public class AdminMenu
    {
        public static WebShopAPI api = new WebShopAPI();

        public static void AdminChoiceOfMenu(int input, int adminId)
        {
            
            switch (input)
            {               
                case 1:
                    //Fråga om bokinfon och spara i variabler, skicka med i metoden nedan
                    AdminBook.AddsBook(adminId);                   
                    break;
                case 2:
                    AdminBook.SetsAmount(adminId);                  
                    break;
                case 3:
                    AdminUsers.PrintUsers(adminId);                   
                    break;
                case 4:
                    AdminUsers.SearchForUser(adminId);
                    break;
                case 5:
                   // api.UpdateBook();
                    break;
                case 6:
                   // api.DeleteBook();
                    break;
                case 7:
                    AdminBookCategory.AddsCategory(adminId);                   
                    break;
                case 8:
                    //api.AddBookToCategory();
                    break;
                case 9:
                    //api.UpdateCategory();
                    break;
                case 10:
                    //api.DeleteCategory();
                    break;
                case 11:
                    AdminUsers.AddingUser(adminId);
                    break;
                default:
                    Messages.WrongInput();
                    break;
                    
           }
        }
    }
}
