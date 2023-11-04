using HrLeaveManagement.Application.DTOs.LeaveRequest;
using HrLeaveManagement.Application.DTOs.LeaveType;
using HrLeaveManagement.Application.Responses;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
