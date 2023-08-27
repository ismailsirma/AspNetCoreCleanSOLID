using AutoMapper;
using HrLeaveManagement.Application.Persistence.Contracts;
using HrLeaveManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HrLeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    internal class CreateLeaveAllocationCommandHandler : IRequestHandler<LeaveRequests.Requests.Commands.CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(LeaveRequests.Requests.Commands.CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = _mapper.Map<LeaveAllocation>(request.LeaveTypeDto);
            leaveAllocation = await _leaveAllocationRepository.Add(leaveAllocation);
            return leaveAllocation.Id;
        }
    }
}