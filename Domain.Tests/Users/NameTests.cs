using FluentAssertions;
using StaffPortalAPI.SharedKernel;

namespace Domain.Tests.Users
{
    public class NameTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Constructor_Should_ThrowArgumentException_WhenValueIsInvalid(string? value)
        {
            Name Action() => new(value);

            // Assert
            FluentActions.Invoking(Action).Should().ThrowExactly<ArgumentNullException>()
                    .Which.ParamName.Should().Be("value");
        }
    }
}