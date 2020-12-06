
using DDDTaiwan2020.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDTaiwan2020.Application.CustomerDetail.Queries
{
    /// <summary>
    /// 查詢 Northwind 的 Customers 的命令
    /// </summary>
    public class GetCustomerDetailQuery: IRequest<IEnumerable<CustomerDetailDto>>
    {
        public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, IEnumerable<CustomerDetailDto>>
        {
            private readonly IApplicationDbContext _context;

            public GetCustomerDetailQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<CustomerDetailDto>> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
            {
                var result = await (from customer in _context.CustomerDetail
                             select new CustomerDetailDto
                             {
                                 CustomerID = customer.CustomerID,
                                 ChtName = customer.ChtName,
                                 Address = customer.Address
                             }).ToListAsync(cancellationToken);

                return result;
                //return await Task.FromResult<IEnumerable<CustomerDetailDto>>(null);
            }
        }
    }
}


