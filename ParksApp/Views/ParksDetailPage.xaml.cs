using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using ParksApp.Models;
using ParksApp.Services;
using ParksApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParksApp.Views

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ParkId),nameof(ParkId))]
    
    public partial class ParksDetailPage : ContentPage
    {
        public string ParkId { get; set; }

        public IParkDataStore<Park> ParkDataStore => DependencyService.Get<IParkDataStore<Park>>();

        // private ParkDetailsViewModel viewModel;

        public ParksDetailPage()
        {
            InitializeComponent();

            //viewModel = new ParkDetailsViewModel();
            //viewModel.ParkId = ParkId;

            //BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            int.TryParse(ParkId, out var parkId);

            BindingContext = await ParkDataStore.GetPark(parkId);
        }


    }
}
