namespace StaffPortalAPI.Application.Abstractions.Messaging;

public interface IUnitOfWork
{
    public Task SaveChangesAsync(CancellationToken cancellationToken);
}
