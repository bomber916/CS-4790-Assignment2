using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CS_4790_Assignment_1.Controllers
{
    public class InventoryController : Controller
    {
        /// <summary>
        /// Passes list of all items in the inventory to the view to display
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            
            return View();
        }
    }
}