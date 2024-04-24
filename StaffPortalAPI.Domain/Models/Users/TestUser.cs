
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Users;

public sealed class TestUser : Entity
{
    private TestUser(TestUserId id, Name firstName, Name lastName, Email email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Id = id;
    }

    private TestUser() { }

    public TestUserId Id { get; private set; }
    public Name FirstName { get; private set; }
    public Name LastName { get; private set; }
    public Email Email { get; private set; }

    public string? PasswordHash { get; set; }
    public string? RefreshToken { get; set; }
    public string? Role { get; set; }

    public static TestUser Create(Name firstName, Name lastName, Email email)
    {
        var user = new TestUser(new TestUserId(Guid.NewGuid()), firstName, lastName, email);

        user.Raise(new UserCreatedDomainEvent(user.Id)); ;

        return user;
    }


}
