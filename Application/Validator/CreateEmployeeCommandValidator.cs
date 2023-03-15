using Application.Handler;
using FluentValidation;

namespace Application.Validator
{
    /// <summary>
    /// CreateEmployeeCommandValidator
    /// </summary>
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmployeeCommandValidator"/> class.
        /// </summary>
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.FirstName)
            .NotEmpty()
            .Length(1, 50);

            RuleFor(x => x.LastName)
           .NotEmpty()
           .Length(1, 50);
        }
    }
}
