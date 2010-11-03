using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Domain.Model;
using Machine.Specifications;
using Website.Controllers;

namespace Website.Tests.Unit.ControllerSpecs
{
    public class HomeControllerSpecs
    {
        protected static HomeController _controller;
        protected static IQueryable<Category> _categories;
        protected static ViewResult _view;

        Establish context = () =>
            {
                _controller = new HomeController();
            };
    }

    public class When_getting_the_index_view_with_categories : HomeControllerSpecs
    {
        Establish context = () =>
            {
                _categories = (new List<Category>()).AsQueryable();
            };

        Because of = () => _view = _controller.Index(_categories);

        It sets_the_view_model_to_all_of_the_categories = () =>
            _view.ViewData.Model.ShouldBeTheSameAs(_categories);
    }
}