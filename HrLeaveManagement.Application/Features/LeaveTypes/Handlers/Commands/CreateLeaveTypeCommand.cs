using AutoMapper;
using HrLeaveManagement.Application.DTOs.LeaveType.Validators;
using HrLeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using HrLeaveManagement.Application.Contracts.Persistence;
using HrLeaveManagement.Application.Responses;
using HrLeaveManagement.Domain;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;

namespace HrLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveTypeDtoValidator();
            //var validationResult = await validator.ValidateAsync(request.LeaveRequestDto);
            
            /*
            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
                //throw new ValidationException(validationResult);
                return response;
            }

            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
            leaveType = await _leaveTypeRepository.Add(leaveType);
            */
            response.Success = true;
            response.Message = "Creation Successful";
            //response.Id = leaveType.Id;
            return response;
        }
    }
}
