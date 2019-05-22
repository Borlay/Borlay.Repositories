using Borlay.Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Borlay.Repositories
{
    public interface IPrimaryTransaction : ITransaction, IDisposable
    {
        byte[] AppendValue(ByteArray entityId, byte[] value, int valueLength);

        //void AppendIndexes(ByteArray entityId, byte[] key, params Index[] indexes);
        void AppendScoreIndex(ByteArray entityId, byte[] key, long score, IndexLevel indexLevel, OrderType orders);

        void Remove(ByteArray entityId);
        void Remove(ByteArray[] entityIds);
    }
}
