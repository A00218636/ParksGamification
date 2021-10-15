using ParksApp.Models;
using ParksApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace ParksApp.ViewModels
{
    class ParksViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Park> Parks { get; set; }

        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand<Park> SelectedCommand { get; }

        //private variable for the tapped value
        Park selectedPark;


        //public variable
        public Park SelectedPark
        {
            get => selectedPark;
            set => SetProperty(ref selectedPark, value);

        }

        public ParksViewModel()
        {
            Title = "Parks";

            Parks = new ObservableRangeCollection<Park>();
            LoadParks();

            RefreshCommand = new AsyncCommand(Refresh);
            SelectedCommand = new AsyncCommand<Park>(Selected);
        }

        async Task Selected(Park park)
        {
            //await Application.Current.MainPage.DisplayAlert("Selected", park.Name, "OK");
            string route = $"{nameof(Views.ParksDetailPage)}?ParkId={park.Id}";
            await Shell.Current.GoToAsync(route);
        }

        private async Task Refresh()
        {
            IsBusy = true;
            Parks.Clear();
            LoadParks();

            IsBusy = false;
        }

        public async void LoadParks()
        {
            //Parks.Add(new Park { Id = 1, Name = "Park A", Description = "Description of park a." });
            //Parks.Add(new Park { Id = 2, Name = "Park B", Description = "Description of park b." });
            //Parks.Add(new Park { Id = 3, Name = "Park C", Description = "Description of park c." });
            //Parks.Add(new Park { Id = 4, Name = "Park D", Description = "Description of park d." });

            IEnumerable<Park> parks = await ParkDataStore.GetParks();

            Parks.AddRange(parks);
        }
    }
}
