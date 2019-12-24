using AutoMapper;
using CarSale.CodeChallenge.Database.EntityModel;
using CarSale.CodeChallenge.Database.Repository;
using CarSale.CodeChallenge.Database.Test.DatbaseTestData;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace CarSale.CodeChallenge.Database.Test.DatabaseService
{
    public class DatbaseServiceTests
    {
        private readonly IVehicleDataService _service;
        private readonly IMapper _mapper;
        private readonly string ContextName = "VehicleDataBase";

        public DatbaseServiceTests()
        {
            //Initiallize Database Context
            DbContextOptions<CarSaleCodeChallengeContext> options;
            var builder = new DbContextOptionsBuilder<CarSaleCodeChallengeContext>();
            builder.UseInMemoryDatabase(ContextName);
            options = builder.Options;
            var context = new CarSaleCodeChallengeContext(options);
            _service = new VehicleDataService(context, _mapper);

        }
        [Theory]
        [ClassData(typeof(DatabaseServiceTestData))]
        public void VehicleCreate_DatabaseReturnValue_Check(Vehicle input, int expectedResult)
        {

            var responce = _service.AddVehicle(input);
            Assert.Equal(expectedResult, responce);
        }
    }
}
