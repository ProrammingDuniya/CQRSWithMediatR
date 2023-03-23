using Core;

namespace Application.Interface
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
