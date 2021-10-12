using ParksApp.Views;
using System;
using Xamarin.Forms;

namespace ParksApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(WelcomePage), typeof(WelcomePage));
            Routing.RegisterRoute(nameof(ParksPage), typeof(ParksPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
        }
    }
}
