using MediatR;

namespace BusinessApp.Application.Commands;

public class CreateEmployeeCommand : IRequest<Guid>
{
    public string FullName { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime HireDate { get; set; } = DateTime.UtcNow;
}