using Core;

namespace Infrastructure.Repository
{
    /// <summary>
    /// IEmployeeQueryRepository
    /// </summary>
    public interface IEmployeeQueryRepository
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public Task<List<Employee>> GetAll();
    }
}
