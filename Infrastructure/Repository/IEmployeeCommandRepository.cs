using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    /// <summary>
    /// IEmployeeCommandRepository
    /// </summary>
    public interface IEmployeeCommandRepository
    {
        /// <summary>
        /// Creates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public Task<Employee> CreateEmployee(string? firstName, string? lastName, DateTime? dateOfBirth);
    }
}
