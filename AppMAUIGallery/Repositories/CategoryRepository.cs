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
                    Description="Organização sequêncial dos elementos.",
                    Page = typeof(StackLayoutPage)
                },
                new Component
                { 
                    Title = "Grid",
                    Description="Organização os elementos dentro de uma tabela.",
                    Page = typeof(GridLayoutPage)
                },
                new Component
                { 
                    Title = "Absolutelayout",
                    Description="Liberdade total para posicionar e dimensionar os elementos na tela.",
                    Page = typeof(AbsoluteLayoutPage)
                },
                new Component
                {
                    Title = "Flexlayout",
                    Description="Organização dos elementos de forma flexível, adaptando-se ao tamanho da tela.",
                    Page = typeof(FlexLayoutPage)
                }
            }                    
        });
        return categories;
    }
}
