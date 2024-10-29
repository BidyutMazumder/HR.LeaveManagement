using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation
{
    public class CreateLeaveAllocationCommandValidator : AbstractValidator<CreateLeaveAllocationCommand>
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public CreateLeaveAllocationCommandValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(LeaveTypeMustExist)
                .WithMessage("{PropertyName} dose not exist.");
            this.leaveTypeRepository = leaveTypeRepository;
        }
        private async Task<bool> LeaveTypeMustExist(int id, CancellationToken token)
        {
            var leaveType = await leaveTypeRepository.GetByIdAsync(id);
            return leaveType != null;
        }
    }
}
