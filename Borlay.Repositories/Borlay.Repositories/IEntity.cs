using Borlay.Arrays;
using System;

namespace Borlay.Repositories
{
    public interface IEntity
    {
        ByteArray Id { get; }
    }
}
