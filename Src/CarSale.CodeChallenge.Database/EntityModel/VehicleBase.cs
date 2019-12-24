using CarSale.CodeChallenge.Shared.SharedVehicleTypeEnum;
namespace CarSale.CodeChallenge.Database.EntityModel
{
    public class VehicleBase
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public VehicleTypes VehicleType { get; set; }
    }
}
