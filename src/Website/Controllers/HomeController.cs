using System.Linq;
using System.Web.Mvc;
using Domain.Model;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index(IQueryable<Category> categories)
        {
            return View(categories);
        }

        public ViewResult Get(Category category)
        {
            return View(category);
        }
    }
}