using CarSale.CodeChallenge.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarSale.CodeChallenge.Domain.Test.VehicleServiceTestData
{
    class VehicleServiceRequestTestData : TheoryData<VehicleRequest, int>
    {
        public VehicleServiceRequestTestData()
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
            }, 1);
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
            }, 2);
            Add(new VehicleRequest()
            {
                Id = 3,
                Make = "dd",
                Model = "gg",
                VehicleType = Shared.SharedVehicleTypeEnum.VehicleTypes.Car,
                BodyType = "tt",
                NoOfWeels = 5,
                NoOfDoors = 4,
                Engine = "tt"
            }, 3);
            Add(new VehicleRequest()
            {
                Id = 4,
                Make = "dd",
                Model = "gg",
                VehicleType = Shared.SharedVehicleTypeEnum.VehicleTypes.Car,
                BodyType = "tt",
                NoOfWeels = 5,
                NoOfDoors = 4,
                Engine = "tt"
            }, 4);
        }

    }
}
