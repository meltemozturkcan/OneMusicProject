using MediatR;
using OneMusic.Application.Interfaces;
using OneMusic.Application.Mediator.Commands;
using OneMusic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.Application.Mediator.Handlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepository<AppUser> _repository;

        public CreateAppUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                Password = request.Password,
                Username = request.Username,
                AppRoleId = request.AppRoleId,
                Email = request.Email,
                Name = request.Name,
                Surname = request.Surname
            });
        }
    }
}
