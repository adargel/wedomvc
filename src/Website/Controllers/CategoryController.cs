using System.Web.Mvc;
using Domain.Model;
using Domain.Storage;

namespace Website.Controllers
{
    public class CategoryController : Controller
    {
        readonly IRepository<Category> _repository;

        public CategoryController(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public ViewResult Index()
        {
            var categories = _repository.All();
            return View(categories);
        }

        public ViewResult View(int id)
        {
            var category = _repository.GetById(id);
            return View(category);
        }
    }
}