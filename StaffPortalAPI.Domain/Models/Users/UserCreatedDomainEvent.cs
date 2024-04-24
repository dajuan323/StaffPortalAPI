using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Domain.Models.Users;

public sealed record UserCreatedDomainEvent(TestUserId UserId) : IDomainEvent;
