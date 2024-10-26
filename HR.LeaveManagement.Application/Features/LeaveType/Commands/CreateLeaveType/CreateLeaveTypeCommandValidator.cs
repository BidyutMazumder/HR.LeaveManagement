using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandValidator: AbstractValidator<CreateLeaveTypeCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public CreateLeaveTypeCommandValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(70).WithMessage("{PropertyName} maximum length is 70");
            RuleFor(p => p.DefaultDays)
                .GreaterThan(100).WithMessage("{PropertyName} Cannot be exceed 100")
                .LessThan(1).WithMessage("{PropertyName} 1");
            RuleFor(p => p)
                .MustAsync(LeaveTypeNAmeUnique)
                .WithMessage("LeaveType Already exist");
            this._leaveTypeRepository = leaveTypeRepository;
        }
        private async Task<bool> LeaveTypeNAmeUnique(CreateLeaveTypeCommand command, CancellationToken token)
        {
            return await _leaveTypeRepository.IsLeaveTypeUnique(command.Name);
        }
    }
}
