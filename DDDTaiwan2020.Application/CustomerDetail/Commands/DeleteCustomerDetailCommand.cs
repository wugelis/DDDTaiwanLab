using DDDTaiwan2020.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDTaiwan2020.Application.CustomerDetail.Commands
{
    /// <summary>
    /// CQRS CustomerDetail 的 Delete Command 命令
    /// </summary>
    public class DeleteCustomerDetailCommand: IRequest<int>
    {
        public int CustomerID {get; set;}
		public string ChtName {get; set;}
		public string AID {get; set;}
		public string Mobile {get; set;}
		public string Tel {get; set;}
		public string Address {get; set;}
		public string Location {get; set;}
		public string EMail {get; set;}
	    public bool Marry {get; set;}
		public int FamilyNum {get; set;}
		public string Education {get; set;}
		public string UserID {get; set;}


        public class DeleteCustomerDetailCommandHandler : IRequestHandler<DeleteCustomerDetailCommand, int>
        {
            private readonly IApplicationDbContext _applicationDbContext;

            public DeleteCustomerDetailCommandHandler(IApplicationDbContext applicationDbContext)
            {
                _applicationDbContext = applicationDbContext;
            }
            public async Task<int> Handle(DeleteCustomerDetailCommand request, CancellationToken cancellationToken)
            {
                /*
                CustomerDetailEnt entity = new CustomerDetailEnt();

                // 設定資料到 Entity
                _applicationDbContext.CustomerDetail.Remove(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                */

                int result = await _applicationDbContext.SaveChangesAsync(cancellationToken);

                return result;
            }
        }
    }
}

