using MediatR;
using OneMusic.Application.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.Application.Mediator.Queries
{
   public class GetCheckAppUserQuery : IRequest<GetCheckAppUserQueryResult>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
