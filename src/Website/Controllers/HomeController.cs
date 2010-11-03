using System.Web.Mvc;
using Domain.Model;
using Domain.Storage;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        readonly IRepository<Category> _repository;

        public HomeController(IRepository<Category> repository)
        {
            _repository = repository;
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