using CarSale.CodeChallenge.Shared.ViewModel;
using Xunit;

namespace CarSale.CodeChallenge.API.Test
{
    public class APIVehicleRequestData : TheoryData<VehicleRequest>
    {
        public APIVehicleRequestData()
        {
            Add(new VehicleRequest()
            {
                Id = 1,
                Make = "aa",
                Model = "bb",
                VehicleType = Shared.SharedVehicleTypeEnum.VehicleTypes.Car,
                BodyType = "qq",
                NoOfWeels = 5,
                NoOfDoors = 4,
                Engine = "gg"
            });
            Add(new VehicleRequest()
            {
                Id = 2,
                Make = "dd",
                Model = "gg",
                VehicleType = Shared.SharedVehicleTypeEnum.VehicleTypes.Car,
                BodyType = "tt",
                NoOfWeels = 5,
                NoOfDoors = 4,
                Engine = "tt"
            });
        }


    }
}

