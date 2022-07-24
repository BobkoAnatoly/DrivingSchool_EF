using DrivingSchool.Database;
using DrivingSchool.Model;
using DrivingSchool.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchool.Controllers
{
    public class VehicleController
    {
        private readonly ApplicationDataBaseContext _context;
        public VehicleController()
        {
            _context = new ApplicationDataBaseContext();
        }

        public List<Vehicle> Get()
        {
            var query = _context.Vehicles.AsNoTracking().AsQueryable().ToList();
            return query;
        }

        public async Task CreateAsync(string vehicleName)
        {
            if (vehicleName != null)
            {
                Vehicle vehicle = new() { Name = vehicleName };
                await _context.Vehicles.AddAsync(vehicle);
                await _context.SaveChangesAsync();
            }
            else
                throw new ArgumentNullException(nameof(vehicleName) +" is Null");
        }

        public async Task UpdateAsync(Nullable<int> vehicleId, Vehicle newVehicle)
        {
            if (vehicleId.HasValue)
            {
                if (newVehicle == null)
                {
                    throw new ArgumentNullException();
                }
                newVehicle.Id = vehicleId.Value;
                _context.Vehicles.Update(newVehicle);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteAsync(Nullable<int> vehicleId)
        {
            if (vehicleId.HasValue)
            {
                var vehicle = await _context.Vehicles.AsNoTracking().FirstOrDefaultAsync(x => x.Id == vehicleId);
                if (vehicle == null) throw new ArgumentNullException(nameof(vehicle) + " is Null");
                _context.Vehicles.Remove(vehicle);
                _context.SaveChanges();
            }
            else
                throw new ArgumentException(nameof(vehicleId)+" is Null");
        }
        

    }
}
