using Application.Interface;
using Core;

namespace Infrastructure.Repository
{
    /// <summary>
    /// EmployeeCommandRepository
    /// </summary>
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        /// <summary>
        /// Creates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public async Task<Employee> CreateEmployee(string? firstName, string? lastName, DateTime? dateOfBirth)
        {
            var emp = Employee.Create(firstName, lastName, dateOfBirth);
            // Create the employee record in a DB

            return emp;
        }
    }
}
