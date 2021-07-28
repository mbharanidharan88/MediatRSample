using MediatR;
using MediatRSample.Data.Entities;
using System;

namespace MediatRSample.Core.Queries
{
    public record GetEmployeeByIdQuery(Guid Id) : IRequest<EmployeeEntity>;
    
}
