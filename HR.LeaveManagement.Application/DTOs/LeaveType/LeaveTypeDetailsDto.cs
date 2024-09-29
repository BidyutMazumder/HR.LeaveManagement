using AutoMapper.Configuration.Conventions;
using HR.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveType
{
    public class LeaveTypeDetailsDto: BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
