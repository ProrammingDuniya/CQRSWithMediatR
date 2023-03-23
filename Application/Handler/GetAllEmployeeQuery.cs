using Application.Interface;
using Application.Model;
using AutoMapper;
using MediatR;

namespace Application.Handler
{
    /// <summary>
    /// GetAllEmployeeQuery
    /// </summary>
    public class GetAllEmployeeQuery : IRequest<List<EmployeeReadModel>>
    {
        /// <summary>
        /// GetAllProductsQueryHandler
        /// </summary>
        public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, List<EmployeeReadModel>>
        {
            private readonly IEmployeeQueryRepository _employeeQueryRepository;
            private readonly IMapper _mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetAllProductsQueryHandler"/> class.
            /// </summary>
            /// <param name="employeeQueryRepository">The employee query repository.</param>
            /// <param name="mapper">The mapper.</param>
            public GetAllEmployeeQueryHandler(IEmployeeQueryRepository employeeQueryRepository, IMapper mapper)
            {
                _employeeQueryRepository = employeeQueryRepository;
                _mapper = mapper;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>
            /// Response from the request
            /// </returns>
            public async Task<List<EmployeeReadModel>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
            {
                var employees = await _employeeQueryRepository.GetAll();
                var e  = _mapper.Map<List<EmployeeReadModel>>(employees);
                return e;
            }
        }
    }
}
