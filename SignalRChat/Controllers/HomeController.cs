using System.Web.Mvc;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
        [Route("Chat")]
        public ViewResult Index()
        {
            return View();
        }
    }
}