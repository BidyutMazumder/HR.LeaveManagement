using AutoMapper;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //validate data

            //map data
            var leaveTypedata = _mapper.Map<Domain.LeaveType>(request);
            //call ripository
            await _leaveTypeRepository.CreateAsync(leaveTypedata);

            //return data
            return leaveTypedata.Id;
        }
    }

}
