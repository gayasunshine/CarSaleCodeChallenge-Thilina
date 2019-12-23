using CarSale.CodeChallenge.Shared.ViewModel;
using FluentValidation;

namespace CarSale.CodeChallenge.Client.Validation
{
    public class VehicleValidator : AbstractValidator<VehicleRequest>
    {
        public VehicleValidator()
        {
            RuleFor(x => x.NoOfDoors).InclusiveBetween(2, 4).WithMessage("No of Doors Should be 4");
            RuleFor(x => x.NoOfWeels).Equal(4).WithMessage("No of Tyres Should be 4");
        }
    }
}
