using CarSale.CodeChallenge.Shared.SharedVehicleTypeEnum;

namespace CarSale.CodeChallenge.Shared.ViewModel
{
   public partial class VehicleRequest
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public VehicleTypes VehicleType { get; set; }
        public int NoOfWeels { get; set; }
        public int NoOfDoors { get; set; }
        public string Engine { get; set; }
    }
}
