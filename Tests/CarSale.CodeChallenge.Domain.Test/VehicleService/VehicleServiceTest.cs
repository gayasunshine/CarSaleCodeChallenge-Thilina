using AutoMapper;
using CarSale.CodeChallenge.Database.Repository;
using CarSale.CodeChallenge.Domain.DomainProfile;
using CarSale.CodeChallenge.Domain.Service;
using CarSale.CodeChallenge.Domain.Test.FackeDataService;
using CarSale.CodeChallenge.Domain.Test.VehicleServiceTestData;
using CarSale.CodeChallenge.Shared.ViewModel;
using System;
using Xunit;

namespace CarSale.CodeChallenge.Domain.Test.VehicleService
{
    public class VehicleServiceTest
    {
        private readonly IVehicleDataService _dataservice;
        private readonly VehicleCreator _service;
        public VehicleServiceTest()
        {
            //Intializing my Mapper
            var domainToEntityProfile = new DomainToEntityProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(domainToEntityProfile));
            var _mapper = new Mapper(configuration);

            _dataservice = new VehicleFakeDataService();
            _service = new VehicleCreator(_dataservice, _mapper);

        }

        [Theory]
        [ClassData(typeof(VehicleServiceRequestTestData))]
        public void VehicleCreate_ServiceReturnValue_Check(VehicleRequest input, int expectedResult)
        {

            var responce = _service.CreateVehicle(input);
            Assert.Equal(expectedResult, responce);
        }
        [Fact]
        public void VehicleCreate_ServiceReturnValue_CheckNotImplementedException()
        {
            VehicleRequest vehicle = new VehicleRequest()
            {
                Id = 2,
                Make = "dd",
                Model = "gg",
                VehicleType = Shared.SharedVehicleTypeEnum.VehicleTypes.Van,
                BodyType = "tt",
                NoOfWeels = 5,
                NoOfDoors = 4,
                Engine = "tt"
            };

            Exception ex = Assert.Throws<NotImplementedException>(() => _service.CreateVehicle(vehicle));
            Assert.Equal("Sorry Type is not Supported", ex.Message);
        }
    }
}
