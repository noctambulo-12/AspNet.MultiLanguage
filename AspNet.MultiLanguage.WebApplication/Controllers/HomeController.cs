using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Threading;

namespace AspNetCore.MultiLanguage.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var selectedCulture = Thread.CurrentThread.CurrentCulture.Name;

            ViewBag.Message = _localizer["El idioma seleccionado es {0}", selectedCulture];

            return View();
        }
    }
}