using CarSale.CodeChallenge.Shared.SharedVehicleTypeEnum;
using CarSale.CodeChallenge.Shared.ViewModel;

namespace CarSale.CodeChallenge.Domain.DomainModels
{
    public class Car : IVehicle
    {
        //Unique Properties for Car Type
        public int NoOfWeels { get; set; }
        public int NOOfDoors { get; set; }
        public string Engine { get; set; }
        public string BodyType { get; set; }
        public Car(VehicleRequest vehicle)
        {

            Id = vehicle.Id;
            Make = vehicle.Make;
            Model = vehicle.Model;
            VehicleType = vehicle.VehicleType;
            BodyType = vehicle.BodyType;
            NoOfWeels = vehicle.NoOfWeels;
            NOOfDoors = vehicle.NoOfDoors;
            Engine = vehicle.Engine;
        }
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public VehicleTypes VehicleType { get; set; }

    }
}
