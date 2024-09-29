using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //CreateMap<LeaveType, LeaveTypeListDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            //CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            //CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsDto>().ReverseMap();
            
        }
    }
}
