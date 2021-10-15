using System;
using ParksApp.Services;
using ParksApp.Models;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace ParksApp.ViewModels
{
     class ParkDetailsViewModel
    {

        public IParkDataStore<Park> ParkDataStore => DependencyService.Get<IParkDataStore<Park>>();

        public string ParkId { get; set; }

        public Park Park { get; set; }

        public ParkDetailsViewModel()
        {

            LoadParkDetails(ParkId);
        }

        public ParkDetailsViewModel(string parkId)
        {
            Park = new Park();
            LoadParkDetails(parkId);



        }




        public async void LoadParkDetails(string parkId)
        {
            //Parks.Add(new Park { Id = 1, Name = "Park A", Description = "Description of park a." });
            //Parks.Add(new Park { Id = 2, Name = "Park B", Description = "Description of park b." });
            //Parks.Add(new Park { Id = 3, Name = "Park C", Description = "Description of park c." });
            //Parks.Add(new Park { Id = 4, Name = "Park D", Description = "Description of park d." });

            //Park parkDetails = await ParkDataStore.GetPark(parkId);
            int p = int.Parse(parkId);
            Park = await ParkDataStore.GetPark(p);



        }
    }
}
