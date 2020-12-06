using DDDTaiwan2020.Application.CustomerDetail.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDTaiwan2020.WebUI.Controllers.Api
{
    public class CustomerApiController : MediatorApiController
    {
        [HttpGet]
        [Route("GetCustomerDetails")]
        public async Task<IEnumerable<CustomerDetailDto>> GetCustomerDetails()
        {
            return await Mediator.Send(new GetCustomerDetailQuery());
        }
    }
}
