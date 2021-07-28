using MediatR;
using MediatRSample.Data.Entities;
using MediatRSample.Core.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatRSample.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace MediatRSample.Core.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeEntity>>
    {
        private readonly EmployeeDbContext _context;

        public GetEmployeeListHandler(EmployeeDbContext context) => _context = context;

        public async Task<List<EmployeeEntity>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
