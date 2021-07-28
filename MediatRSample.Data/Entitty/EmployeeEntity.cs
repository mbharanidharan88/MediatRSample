using System;

namespace MediatRSample.Data.Entities
{
    public class EmployeeEntity
    {
        public Guid Id { get; set; }

        public string FirstName{ get; set; }

        public string LastName { get; set; }
    }
}
