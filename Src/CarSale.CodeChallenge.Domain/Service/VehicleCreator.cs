using AutoMapper;
using CarSale.CodeChallenge.Database.EntityModel;
using CarSale.CodeChallenge.Database.Repository;
using CarSale.CodeChallenge.Shared.ViewModel;
using CarSales.CodeChallenge.Shared.Factory;
namespace CarSale.CodeChallenge.Domain.Service
{
    public class VehicleCreator : IVehicleCreator
    {
        private readonly IVehicleDataService _service;
        private readonly IMapper _mapper;
        public VehicleCreator(IVehicleDataService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public int CreateVehicle(VehicleRequest vehicle)
        {
            int vehicleId = 0;
            //Get the resolved vehicle from Factory
            var createdVehicle = VehicleFactory.CreateVehicle(vehicle);
            //Map the Ivehicle for Entity Type by Auto Mapper
            var vehicleEntity = _mapper.Map<Vehicle>(createdVehicle);
            if (vehicleEntity != null)
            {
                vehicleId = _service.AddVehicle(vehicleEntity);
            }
            return vehicleId;

        }
    }
}
