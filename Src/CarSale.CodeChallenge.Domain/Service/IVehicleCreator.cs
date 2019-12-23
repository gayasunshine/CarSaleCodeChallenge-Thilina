
using CarSale.CodeChallenge.Domain.DomainModels;
using CarSale.CodeChallenge.Shared.ViewModel;

namespace CarSale.CodeChallenge.Domain.Service
{
    public interface IVehicleCreator
    {
        int CreateVehicle(VehicleRequest vehicle);
    }
}
