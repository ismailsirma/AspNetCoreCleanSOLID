using HrLeaveManagement.Domain;
using HrLeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;
using HrLeaveManagement.Application.DTOs.LeaveType;

namespace HrLeaveManagement.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
