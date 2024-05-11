using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Requests
{
    public class GetLeaveTypeListRequest: IRequest<List<LeaveTypetDto>>
    {
    }
}
