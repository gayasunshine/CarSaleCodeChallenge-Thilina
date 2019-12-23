using CarSale.CodeChallenge.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarSale.CodeChallenge.Domain.Test.ServiceTestData
{
    public class DummyServiceData : TheoryData<VehicleRequest>
    {
        public DummyServiceData()
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

