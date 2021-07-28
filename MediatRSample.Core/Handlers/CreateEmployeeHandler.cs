using MediatR;
using MediatRSample.Core.Commands;
using MediatRSample.Data.Context;
using MediatRSample.Data.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRSample.Core.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, EmployeeEntity>
    {
        private readonly EmployeeDbContext _context;

        public CreateEmployeeHandler(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<EmployeeEntity> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new EmployeeEntity
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            await _context.AddAsync(employee);

            await _context.SaveChangesAsync();

            return employee;
        }
    }
}
