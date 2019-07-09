namespace ExampleCQRS.Domain.Commands
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Interfaces;
    using FluentValidation.Results;

    public abstract class Command : ICommand
    {
        public abstract Task<ValidationResult> IsValidAsync();
    }
}