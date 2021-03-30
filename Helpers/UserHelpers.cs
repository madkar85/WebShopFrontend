using System;
using System.Collections.Generic;
using System.Text;
using WebShopAssignment;
using WebShopFrontend.Controller;

namespace WebShopFrontend.Helpers
{
    public class UserHelpers
    {
        public static WebShopAPI api = new WebShopAPI();

        public static bool IsUserActice(int adminId)
        {
            var userActive = api.Ping(adminId);
            if (userActive != "pong")
            {
                LoginMenu.LoginAgain();
            }
            return true;
        }


    }
}
