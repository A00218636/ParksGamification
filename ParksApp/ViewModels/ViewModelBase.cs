using MvvmHelpers;
using ParksApp.Models;
using ParksApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ParksApp.ViewModels
{
    class ViewModelBase : BaseViewModel
    {
        public IParkDataStore<Park> ParkDataStore => DependencyService.Get<IParkDataStore<Park>>();
    }
}
