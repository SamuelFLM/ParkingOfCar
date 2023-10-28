using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parking.Domain.Entities;

namespace Parking.Domain.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetVehicleAsync();
    }
}