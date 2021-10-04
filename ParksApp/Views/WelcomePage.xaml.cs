using ParksApp.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParksApp.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new WelcomeViewModel();

            var learnMoreButton = new Button() { Text = "Learn More" };
            learnMoreButton.SetBinding(Button.CommandProperty, new Binding("OpenWebCommand"));

            var testPageButton = new Button() { Text = "Go to test page" };
            testPageButton.SetBinding(Button.CommandProperty, new Binding("GoToTestPageCommand"));

            Content = new StackLayout()
            {
                Padding = 30,
                Children =
                {
                    learnMoreButton
                }
            };
        }
    }
}