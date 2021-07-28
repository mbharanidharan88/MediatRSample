using MediatR;
using MediatRSample.Data.Entities;

namespace MediatRSample.Core.Commands
{
    public record CreateEmployeeCommand(string FirstName, string LastName) 
                                                        : IRequest<EmployeeEntity>;
}
