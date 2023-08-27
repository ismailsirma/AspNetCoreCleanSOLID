using HrLeaveManagement.Application.DTOs.Common;
using HrLeaveManagement.Application.DTOs.LeaveType;
using System;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
