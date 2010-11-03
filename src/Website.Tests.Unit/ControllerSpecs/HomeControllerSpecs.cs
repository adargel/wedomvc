using Machine.Specifications;

namespace Website.Tests.Unit.ControllerSpecs
{
    public class HomeControllerSpecs
    {
        
    }

    public class When_getting_the_index_view_with_categories
    {
        It sets_the_view_model_to_all_of_the_categories;
    }

    public class When_getting_the_index_view_without
    {
        It redirects_the_user_to_the_add_categories_page;
    }
}