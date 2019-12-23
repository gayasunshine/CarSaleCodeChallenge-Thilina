using AutoMapper;
using CarSale.CodeChallenge.Shared.ViewModel;
using CarSale.CodeChallenge.Domain.DomainModels;
using CarSale.CodeChallenge.Domain.Service;
using CarSale.CodeChallenge.Shared.SharedVehicleTypeEnum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CarSale.CodeChallenge.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleCreatorController : Controller
    {

        private readonly IVehicleCreator _service;
        private readonly ILogger<VehicleCreatorController> _logger;
        private readonly IMapper _mapper;

        public VehicleCreatorController(IVehicleCreator service, ILogger<VehicleCreatorController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;

        }


        // POST: api/VehicleCreator
        [HttpPost]
        [Route("CreateVehicle")]
        public ActionResult Post([FromBody] VehicleRequest request)
        {
            try
            {
                int vehicleId = 0;
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                vehicleId = _service.CreateVehicle(request);


                return CreatedAtAction("Completed",vehicleId); ;

            }

            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                var errorModel = new { error = "Something went wrong while Posting Vehicle. See log records for more details." };
                return BadRequest(errorModel);
            }


        }
    }
}
