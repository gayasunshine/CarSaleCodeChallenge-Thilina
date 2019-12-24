using CarSale.CodeChallenge.Database.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarSale.CodeChallenge.Database.Test.DatbaseTestData
{
   public class DatabaseServiceTestData: TheoryData<Vehicle,int>
    {
        public DatabaseServiceTestData()
        {
            Add(new Vehicle()
            {
                Id = 0,
                Make = "aa",
                Model = "bb",
                VehicleType = Shared.SharedVehicleTypeEnum.VehicleTypes.Car,
                BodyType = "qq",
                NoOfWeels = 5,
                NoOfDoors = 4,
                Engine = "gg"
            },1);
            Add(new Vehicle()
            {
                Id = 0,
                Make = "dd",
                Model = "gg",
                VehicleType = Shared.SharedVehicleTypeEnum.VehicleTypes.Car,
                BodyType = "tt",
                NoOfWeels = 5,
                NoOfDoors = 4,
                Engine = "tt"
            },2);
        }
    }
}
