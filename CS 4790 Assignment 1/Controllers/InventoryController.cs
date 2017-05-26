using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS_4790_Assignment_1.Models;

namespace CS_4790_Assignment_1.Controllers
{
    public class InventoryController : Controller
    {
        /// <summary>
        /// Passes list of all items in the inventory to the view to display
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            return View(Repository.InventoryItems);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        /// <summary>
        /// Builds an inventory item and adds it to the repository
        /// </summary>
        [HttpPost]
        public ViewResult Create(InventoryItem item)
        {
            if (item != null)
            {
                Repository.AddInventoryItem(item);
            }
            return View(item);
        }
    }
}