using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DangnhapController : Controller
    {
        public IActionResult Index() 
        { 
            return View(); 
        
        }
       
        public IActionResult Index(KT kt)
        {
            ViewBag.Massage = $"Name:{kt.UserName}, Pass:{kt.Password}";
           return View(kt);
        }
    }
}
