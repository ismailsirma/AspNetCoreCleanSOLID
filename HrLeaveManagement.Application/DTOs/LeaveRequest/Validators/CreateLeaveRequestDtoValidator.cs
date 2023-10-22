using FluentValidation;
using HrLeaveManagement.Application.Contracts.Persistence;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public CreateLeaveAllocationDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;
            Include(new ILeaveRequestDtoValidator(_leaveRequestRepository));
        }
    }
}
