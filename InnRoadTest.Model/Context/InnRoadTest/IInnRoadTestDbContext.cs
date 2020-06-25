using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InnRoadTest.Model.Context.InnRoadTest
{
    public interface IInnRoadTestDbContext: IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        DbSet<T> GetDbSet<T>() where T : class;
        EntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
