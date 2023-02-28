using VolleyballTeam.Models;
using Microsoft.AspNetCore.Mvc;

namespace VolleyballTeam.Controllers
{
    public class JoinController : Controller
    {
        public IActionResult Index() // join
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Join join)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
