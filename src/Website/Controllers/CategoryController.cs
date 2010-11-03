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
            return View();
        }

        public ViewResult View(int categoryId)
        {
            var category = _repository.GetById(categoryId);
            return View(category);
        }
    }
}