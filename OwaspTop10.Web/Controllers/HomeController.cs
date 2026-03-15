using Microsoft.AspNetCore.Mvc;
using OwaspTop10.Web.Services;

namespace OwaspTop10.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly OwaspCatalogService _catalog;

        public HomeController(OwaspCatalogService catalog)
        {
            _catalog = catalog;
        }

        public IActionResult Index()
        {
            var items = _catalog.GetAll();
            return View(items);
        }
    }
}
