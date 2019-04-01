using Borlay.Arrays;
using System;

namespace Borlay.Repositories
{
    public interface IEntity
    {
        ByteArray Id { get; }
    }

    public interface IScoreEntity : IEntity
    {
        long Score { get; }
    }
}
