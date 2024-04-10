using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Text.RegularExpressions;
using webi18n.Models;

namespace webi18n.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
            private readonly IStringLocalizer<HomeController> localizer;



        /// <summary>
        /// 获取多语言信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            string rsstr= localizer.GetString("String1").Value;//?ui-culture=zh
            return rsstr;
        }




        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            this.localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewBag.rsstr= localizer.GetString("String1").Value;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
