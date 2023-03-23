using Application.Interface;
using Core;

namespace Infrastructure.Repository
{
    /// <summary>
    /// EmployeeQueryRepository
    /// </summary>
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Employee>> GetAll()
        {
            // Get the employee record from a data store
            // Below is for demo purposes only
            var employee = new List<Employee>();

            return employee;
        }
    }
}
