using System.Collections.Generic;
using System.Web.Mvc;
using Domain.Model;
using Domain.Queries;
using Domain.Storage;

namespace Website.Controllers
{
    public class CategoriesController : Controller
    {
        readonly IRepository<Category> _repository;

        public CategoriesController(IRepository<Category> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ViewResult Find()
        {
            return View(new List<Category>());
        }

        [HttpPost]
        public ViewResult Find(string name)
        {
            var categories = _repository.All().Where().NameEquals(name);
            return View(categories);
        }
    }
}