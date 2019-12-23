using CarSale.CodeChallenge.Domain.DomainModels;
using CarSale.CodeChallenge.Shared.SharedVehicleTypeEnum;
using CarSale.CodeChallenge.Shared.ViewModel;
using System;

namespace CarSales.CodeChallenge.Shared.Factory
{
   public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(VehicleRequest vehicle)
        {
            IVehicle resolvedVehicle = null;
            switch (vehicle.VehicleType)
            {
                case VehicleTypes.Car:
                    resolvedVehicle = new Car(vehicle);
                    break;
                case VehicleTypes.Van:
                    throw new NotImplementedException("Sorry Type is not Supported");
                case VehicleTypes.Boat:
                    throw new NotImplementedException("Sorry Type is not Supported");
                default:
                    break;
            }
            return resolvedVehicle;




        }

    }
}
