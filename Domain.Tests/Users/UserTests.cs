using FluentAssertions;
using StaffPortalAPI.Domain.Models.Users;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests.Users;

public class UserTests
{
    [Fact]
    public void Create_Should_ReturnUser_WhenNameIsValid()
    {
        // Arrange
        var email = Email.Create("test@tes.com").Value;
        var firstName = new Name("First");
        var lastName = new Name("Last");

        // Action
        var user = TestUser.Create(firstName, lastName, email);

        // Assert
        user.Should().NotBeNull();
    }    
    
    [Fact]
    public void Create_Should_RaiseDomainEvent_WhenNameIsValid()
    {
        // Arrange
        var email = Email.Create("test@test.com").Value;
        var firstName = new Name("First");
        var lastName = new Name("Last");

        // Action
        var user = TestUser.Create(firstName, lastName, email);

        // Assert
        user.DomainEvents.Should().ContainSingle()
            .Which.Should().BeOfType<UserCreatedDomainEvent>();
    }

}
