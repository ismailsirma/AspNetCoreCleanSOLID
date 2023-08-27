using HrLeaveManagement.Application.DTOs.Common;
using HrLeaveManagement.Application.DTOs.LeaveType;
using System;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto : ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
    }
}
