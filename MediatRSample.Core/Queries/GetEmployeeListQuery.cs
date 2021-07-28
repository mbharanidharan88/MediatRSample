using MediatR;
using MediatRSample.Data.Entities;
using System.Collections.Generic;

namespace MediatRSample.Core.Queries
{
    public record GetEmployeeListQuery() : IRequest<List<EmployeeEntity>>;
    
}
