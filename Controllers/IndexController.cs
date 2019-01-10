using Microsoft.AspNetCore.Mvc;
namespace RazorFun
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}