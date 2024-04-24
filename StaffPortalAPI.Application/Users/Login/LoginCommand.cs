using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StaffPortalAPI.Application.Users.Login;

public sealed record LoginCommand(string Email) : ICommand<Result<string>>;

