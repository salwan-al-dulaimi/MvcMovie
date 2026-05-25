using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{

    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var items = new Item()
            {
                Name = "Item 1",
            };

            return View(items);
        }

        public IActionResult Edit(int id)
        {

            return Content("Edit action for item with ID: " + id);
        }
    }
}