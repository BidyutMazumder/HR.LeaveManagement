using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Requests.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Handlers.Commands.UpdateLeaveType
{
    public class UpdateLeaveTypeCommandHandlerb : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveTypeCommandHandlerb(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            // validate
            // map
            var leaveType = _mapper.Map<Domain.LeaveType>(request);
            // call repository
            await _leaveTypeRepository.UpdateAsync(leaveType);
            // return 
            return Unit.Value;
        }
    }
}
