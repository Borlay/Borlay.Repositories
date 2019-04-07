using Borlay.Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Borlay.Repositories
{
    public interface IPrimaryTransaction : ITransaction, IDisposable
    {
        byte[] AppendValue(ByteArray entityId, byte[] value, int valueLength);

        void AppendIndexes(ByteArray entityId, byte[] key, params Index[] indexes);

        void AppendOrderIndex(ByteArray entityId, byte[] key, IndexLevel indexLevel, long score, OrderType orders);
    }
}
