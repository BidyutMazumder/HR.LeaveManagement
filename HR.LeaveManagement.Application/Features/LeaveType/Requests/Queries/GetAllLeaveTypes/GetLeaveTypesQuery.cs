using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Requests.Queries.GetAllLeaveTypes
{
    //public class GetLeaveTypesQuery : IRequest<List<LeaveTypetDto>>
    //{
    //}

    public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
}
