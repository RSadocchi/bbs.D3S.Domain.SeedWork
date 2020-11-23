using System;

namespace bbs.D3S.Domain.SeedWork
{
    public interface IDbTransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
