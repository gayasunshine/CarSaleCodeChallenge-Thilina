using AutoMapper;
using CarSale.CodeChallenge.API.Test.FackeService;
using CarSale.CodeChallenge.Client.Controllers;
using CarSale.CodeChallenge.Domain.Service;
using CarSale.CodeChallenge.Shared.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace CarSale.CodeChallenge.API.Test.APIController
{
    public class APIControllerTests
    {
        private readonly VehicleCreatorController _controller;
        private readonly IVehicleCreator _service;
        private readonly ILogger<VehicleCreatorController> _logger;
        private readonly IMapper _mapper;
        public APIControllerTests()
        {
            _service = new VehicleCreatorFakeService();
            _controller = new VehicleCreatorController(_service, _logger, _mapper);
        }

        [Theory]
        [ClassData(typeof(APIVehicleRequestData))]
        public void VehicleCreate_ControllerReturnType_Check(VehicleRequest input)
        {
            var responce = _controller.Post(input);
            Assert.IsType<CreatedAtActionResult>(responce);
        }

        [Theory]
        [ClassData(typeof(APIVehicleRequestData))]
        public void VehicleCreate_ControllerReturnResponceHasCreatedItem(VehicleRequest input)
        {

            // Act
            var createdResponse = _controller.Post(input) as CreatedAtActionResult;
            var item = createdResponse.Value;

            // Assert
            Assert.Equal(input.Id.ToString(), item.ToString());
        }

        [Theory]
        [ClassData(typeof(APIVehicleRequestData))]
        public void VehicleCreate_ControllerReturnBadResponce(VehicleRequest input)
        {
            _controller.ModelState.AddModelError("Model", "Required");
            // Act
            var badResponse = _controller.Post(input);
            // Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

    }
}

