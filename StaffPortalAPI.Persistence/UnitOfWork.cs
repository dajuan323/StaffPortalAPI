using StaffPortalAPI.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffPortalAPI.Application.Abstractions.Messaging;

namespace StaffPortalAPI.Persistence;

internal sealed class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _appContext;
    public UnitOfWork(ApplicationDbContext appContext)
    {
        _appContext = appContext;
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _appContext.SaveChangesAsync(cancellationToken);
    }


}
