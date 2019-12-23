using AutoMapper;
using CarSale.CodeChallenge.Client.Controllers;
using CarSale.CodeChallenge.Domain.Service;
using CarSale.CodeChallenge.Domain.Test.FackeService;
using CarSale.CodeChallenge.Domain.Test.ServiceTestData;
using CarSale.CodeChallenge.Shared.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarSale.CodeChallenge.Domain.Test.ServiceTest
{
  public  class VehicleServiceTests
    {
       private readonly VehicleCreatorController _controller;
       private readonly IVehicleCreator _service;
        private readonly ILogger<VehicleCreatorController> _logger;
        private readonly IMapper _mapper;

        public VehicleServiceTests()
        {
            _service = new VehicleCreatorFakeService();
            _controller = new VehicleCreatorController(_service, _logger, _mapper);
        }

        [Theory]
        [ClassData(typeof(DummyServiceData))]
        public void VehicleCreate_ControllerReturnType_Check(VehicleRequest input)
        {
            var responce = _controller.Post(input);
            Assert.IsType<CreatedAtActionResult>(responce);
        }

        [Theory]
        [ClassData(typeof(DummyServiceData))]
        public void VehicleCreate_ControllerReturnResponceHasCreatedItem(VehicleRequest input)
        {
 
            // Act
            var createdResponse = _controller.Post(input) as CreatedAtActionResult;
            var item = createdResponse.Value;

            // Assert
            Assert.Equal(input.Id.ToString(), item.ToString());
        }

    }
    }

