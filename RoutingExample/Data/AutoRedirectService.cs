using Microsoft.AspNetCore.Components;

namespace RoutingExample.Data
{
    public class AutoRedirectService
    {
        private readonly NavigationManager _navigationManager;

        public AutoRedirectService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void RedirectToBlazorSchool()
        {
            _navigationManager.NavigateTo("https://blazorschool.com");
        }
    }
}
