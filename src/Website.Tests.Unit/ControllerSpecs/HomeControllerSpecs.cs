using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Domain.Model;
using Domain.Storage;
using Machine.Specifications;
using Rhino.Mocks;
using Website.Controllers;

namespace Website.Tests.Unit.ControllerSpecs
{
    public class HomeControllerSpecs
    {
        protected static HomeController _controller;
        protected static IRepository<Category> _repository;
        protected static IQueryable<Category> _categories;
        protected static ViewResult _view;

        Establish context = () =>
            {
                _repository = MockRepository.GenerateMock<IRepository<Category>>();
                _controller = new HomeController(_repository);
            };
    }

    public class When_getting_the_index_view_with_categories : HomeControllerSpecs
    {
        Establish context = () =>
            {
                _categories = (new List<Category>()).AsQueryable();
                _repository.Stub(x => x.All()).Return(_categories);
            };

        Because of = () => _view = _controller.Index();

        It gets_the_categories_from_the_repository = () =>
            _repository.AssertWasCalled(x => x.All());

        It sets_the_view_model_to_all_of_the_categories = () =>
            _view.ViewData.Model.ShouldBeTheSameAs(_categories);
    }
}