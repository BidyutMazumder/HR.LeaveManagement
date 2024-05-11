using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.Features.LeaveType.Requests;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandlers : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypetDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeListRequestHandlers(ILeaveTypeRepository leaveTypeRepository, IMapper mapper) 
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }
        public async Task<List<LeaveTypetDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypetDto>>(leaveType);
        }
    }
}
