using AutoMapper;
using HrLeaveManagement.Application.DTOs.LeaveAllocation;
using HrLeaveManagement.Application.DTOs.LeaveRequest;
using HrLeaveManagement.Application.DTOs.LeaveType;
using HrLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
