using BusinessApp.Core.Entities;

namespace BusinessApp.Core.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee> AddAsync(Employee employee);
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<Employee?> GetByIdAsync(Guid id);
    Task<bool> DeleteAsync(Guid id);
}