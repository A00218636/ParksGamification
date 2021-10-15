using ParksApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParksApp.Services
{
    public interface IParkDataStore<T>
    {
        Task<IEnumerable<Park>> GetParks();
        Task<Park> GetPark(int parkId);
    }
}
