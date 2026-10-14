
using Microsoft.AspNetCore.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Thank you for your feedback!";
                return View(new Feedback());
            }

            return View(feedback);
        }
    }
}
