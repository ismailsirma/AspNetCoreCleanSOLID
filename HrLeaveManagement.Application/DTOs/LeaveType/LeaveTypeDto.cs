﻿using HrLeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto, ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
