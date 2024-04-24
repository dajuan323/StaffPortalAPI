using MediatR;
using MediatR.Pipeline;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Domain.Models.Users;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Application.Users.Login
{
    internal sealed class LoginCommandHandler
        : ICommandHandler<LoginCommand, Result<string>>
    {

        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<Result<Result<string>>> Handle(LoginCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
