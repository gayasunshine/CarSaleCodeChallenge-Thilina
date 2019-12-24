using AutoMapper;
using CarSale.CodeChallenge.Database.EntityModel;
using CarSale.CodeChallenge.Domain.DomainModels;

namespace CarSale.CodeChallenge.Domain.DomainProfile
{
    public class DomainToEntityProfile : Profile
    {
        public DomainToEntityProfile()
        {
            CreateMap<IVehicle, VehicleBase>().Include<Car, Vehicle>();
            CreateMap<Car, Vehicle>();
        }

    }
}
