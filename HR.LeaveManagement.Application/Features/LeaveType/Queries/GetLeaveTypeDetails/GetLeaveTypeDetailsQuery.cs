using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    //public class GetLeaveTypeDetailsQuery : IRequest<LeaveTypetDetailsDto>
    //{
    //    public int Id { get; set; } 
    //    public GetLeaveTypesDetailsQuery(int id)
    //    {
    //        Id = id;
    //    }   
    //}

    public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;
}
