using ParksApp.Models;
using ParksApp.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ParksApp.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel()
        {
            Title = "Welcome";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            //Code for Test page command
            GoToTestPageCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(TestPage)));

            var park = new Models.Park();
            park.Id = 1;
            park.Name = "GreenPark";
            park.Description = "This is an awesome park.";

            park.Amenities.Add(new Park.Amenity() { Type = Park.Amenity.Types.Swing, Quantity = 1, Description = "Blue swing for ages 3 to 7. " });
            park.Amenities.Add(new Park.Amenity() { Type = Park.Amenity.Types.Swing, Quantity = 1, Description = "Green swing for ages 3 to 7. " });



        }

        public ICommand OpenWebCommand { get; }
        public ICommand GoToTestPageCommand { get; }
    }
}