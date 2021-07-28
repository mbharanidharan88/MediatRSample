using MediatR;
using MediatRSample.Data.Entities;
using MediatRSample.Core.Queries;
using System.Threading;
using System.Threading.Tasks;
using MediatRSample.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace MediatRSample.Core.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        private readonly EmployeeDbContext _context;

        public GetEmployeeByIdHandler(EmployeeDbContext context) => _context = context;

        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Employees.FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}
