using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class Start : Controller
    {
        public string Hello()
        {
            var currentHour = DateTime.Now.Hour;
            if (currentHour < 6)
            {
                return "Good Night!";
            }
            if (currentHour < 12)
            {
                return "Good Morning!";
            }            
            if (currentHour < 18)
            {
                return "Good Afternoon!";
            }
            if (currentHour < 20)
            {
                return "Good Evening!";
            }
            return "Good Night!";
            
        }
    }
}
