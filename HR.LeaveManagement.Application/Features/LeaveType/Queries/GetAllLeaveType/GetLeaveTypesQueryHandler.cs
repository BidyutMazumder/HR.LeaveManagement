using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetLeaveTypesQueryHandler> _appLogger;

        public GetLeaveTypesQueryHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, IAppLogger<GetLeaveTypesQueryHandler> appLogger)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _appLogger = appLogger;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {
            //Query
            var leaveTypes = await _leaveTypeRepository.GetAsync();       
            //convert
            var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
            //return 
            _appLogger.LogInformation("Data retrive successfully");
            return data;
        }
    }
}
