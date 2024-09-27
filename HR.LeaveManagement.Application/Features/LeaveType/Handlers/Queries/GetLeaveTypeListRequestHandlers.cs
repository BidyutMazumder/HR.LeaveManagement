using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Requests.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandlers : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypetDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        GetLeaveTypeListRequestHandlers(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }
        public async Task<List<LeaveTypetDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetAsync();
            return _mapper.Map<List<LeaveTypetDto>>(leaveType);
        }
    }
}
