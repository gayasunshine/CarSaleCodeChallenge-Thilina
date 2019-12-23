using CarSale.CodeChallenge.Domain.Service;
using CarSale.CodeChallenge.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSale.CodeChallenge.Domain.Test.FackeService
{
    public class VehicleCreatorFakeService : IVehicleCreator
    {
        private readonly List<VehicleRequest> _request;
        public VehicleCreatorFakeService()
        {
            _request = new List<VehicleRequest>()
            {
            };
            }



        public int CreateVehicle(VehicleRequest newItem)
            {
                _request.Add(newItem);
                return newItem.Id;
            }
        }
    }
