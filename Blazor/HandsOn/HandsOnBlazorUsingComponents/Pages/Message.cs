using Microsoft.AspNetCore.Components;

namespace HandsOnBlazorUsingComponents.Pages
{
    public class MessageBase : ComponentBase
    {
        protected string Name = "Virat";
        protected void SetName()
        {
            Name = "Rohith";
        }
    }
    
}
