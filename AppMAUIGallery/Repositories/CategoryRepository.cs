using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Layouts;

namespace AppMAUIGallery.Repositories;

public class CategoryRepository
{
    public CategoryRepository() { }

    public List<Category> GetCategories()
    {
        List<Category> categories = new List<Category>();

        categories.Add(new Category
        {
            Name= "Layout",
            Components = new List<Component> { 
                new Component
                { 
                    Title = "Stacklayout",
                    Description="Organização sequêncial dos elementos",
                    Page = typeof(StackLayoutPage)
                },
                new Component
                { 
                    Title = "Grid",
                    Description="Organização os elementos dentro de uma tabela",
                    Page = typeof(GridLayoutPage)
                },
            }            
        });
        return categories;
    }
}
