using HandsOnBlazorUsingModels.Model;
using Microsoft.AspNetCore.Components;

namespace HandsOnBlazorUsingModels.Codebase
{
    public class ProductBase:ComponentBase
    {
        protected Product product = new Product()
        {
            Id = 1,
            Name = "Mouse",
            Price = 400
        };
        protected List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Id=1,Name="Mouse",Price=400},
                 new Product(){Id=2,Name="AAA",Price=40},
                  new Product(){Id=3,Name="Keyboard",Price=700},
                   new Product(){Id=4,Name="Speakers",Price=3400},
                    new Product(){Id=5,Name="JoyStick",Price=1400},
            };
        }
    }
}
