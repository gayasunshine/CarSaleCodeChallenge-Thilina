using AutoMapper;
using CarSale.CodeChallenge.Database.EntityModel;
using System.Linq;

namespace CarSale.CodeChallenge.Database.Repository
{
    public class VehicleDataService : IVehicleDataService
    {
        private readonly CarSaleCodeChallengeContext _context;
        public VehicleDataService(CarSaleCodeChallengeContext context, IMapper mapper)
        {
            _context = context;

        }
        public int AddVehicle(Vehicle vehicleEntity)
        {
            if (_context.Vehicle.Any())
            {

                //Determine the next ID
                var newID = _context.Vehicle.Select(x => x.Id).Max() + 1;
                vehicleEntity.Id = newID;

                {
                    _context.Vehicle.Add(vehicleEntity);
                    _context.SaveChanges();
                }
            }
            else
            {
                _context.Vehicle.Add(vehicleEntity);
                _context.SaveChanges();
            }
            return vehicleEntity.Id;


        }

    }

}

