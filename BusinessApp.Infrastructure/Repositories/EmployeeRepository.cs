using BusinessApp.Core.Entities;
using BusinessApp.Core.Interfaces;
using BusinessApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BusinessApp.Infrastructure.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext _context;

    public EmployeeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Employee> AddAsync(Employee employee)
    {
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        return employee;
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee?> GetByIdAsync(Guid id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var emp = await _context.Employees.FindAsync(id);
        if (emp == null) return false;
        _context.Employees.Remove(emp);
        await _context.SaveChangesAsync();
        return true;
    }
}