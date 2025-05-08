using BusinessApp.Application.Commands;
using BusinessApp.Core.Entities;
using BusinessApp.Core.Interfaces;
using MediatR;

namespace BusinessApp.Application.Handlers;

public class CreateEmployeeHandler(IEmployeeRepository repository) : IRequestHandler<CreateEmployeeCommand, Guid>
{
    public async Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var employee = new Employee
        {
            FullName = request.FullName,
            Position = request.Position,
            HireDate = request.HireDate
        };

        var created = await repository.AddAsync(employee);
        return created.Id;
    }
}