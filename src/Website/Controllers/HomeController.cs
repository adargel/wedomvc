using System.Linq;
using System.Web.Mvc;
using Domain.Model;
using Storage;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        readonly EfRepository<Category> _repository;

        public HomeController()
        {
            _repository = new EfRepository<Category>(new EfDatabaseContext());
        }

        public ViewResult Index()
        {
            var categories = _repository.All();
            return View(categories);
        }

        public ViewResult Get(int id)
        {
            var category = _repository.GetById(id);
            return View(category);
        }
    }
}