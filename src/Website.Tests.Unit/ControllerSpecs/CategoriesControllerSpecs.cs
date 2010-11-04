using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Domain.Model;
using Domain.Queries;
using Domain.Queries.Providers;
using Domain.Storage;
using Machine.Specifications;
using Rhino.Mocks;
using Website.Controllers;

namespace Website.Tests.Unit.ControllerSpecs
{
    public class CategoriesControllerSpecs
    {
        protected static string _expectedNameToSearchFor = "SearchForMe";
        protected static IRepository<Category> _repository;
        protected static ICategoryQueryProvider _mockProvider;
        protected static CategoriesController _controller;
        protected static IQueryable<Category> _expectedQueryResults;
        protected static ViewResult _view;

        Establish context = () =>
            {
                _repository = MockRepository.GenerateStub<IRepository<Category>>();
                _mockProvider = MockRepository.GenerateMock<ICategoryQueryProvider>();
                _expectedQueryResults = (new List<Category>()).AsQueryable();
                _mockProvider.Stub(x => x.NameIsLike(_expectedNameToSearchFor)).Return(_expectedQueryResults);
                CategoryQueryExtensions.Provider = x => _mockProvider;
                _controller = new CategoriesController(_repository);
            };
    }

    public class When_finding_a_category : CategoriesControllerSpecs
    {
        Because of = () =>
            _view = _controller.Find(_expectedNameToSearchFor);

        It searches_for_categories_with_names_that_contain_values_entered = () =>
            _mockProvider.AssertWasCalled(x => x.NameIsLike(_expectedNameToSearchFor));

        It assigns_the_returned_value_to_the_view_model = () =>
            _view.ViewData.Model.ShouldBeTheSameAs(_expectedQueryResults);
    }
}