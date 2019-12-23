﻿using CarSale.CodeChallenge.Shared.SharedVehicleTypeEnum;
using System.Collections.Generic;

namespace CarSale.CodeChallenge.Domain.DomainModels
{
    public interface IVehicle
    {
        public abstract int Id { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract VehicleTypes VehicleType { get; set; }
       
       
        

    }
}
