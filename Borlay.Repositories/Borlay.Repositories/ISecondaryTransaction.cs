using Borlay.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Repositories
{
    public interface ISecondaryTransaction : ITransaction, IDisposable
    {
        byte[] AppendValue(ByteArray parentId, ByteArray entityId, byte[] value, int valueLength);

        //void AppendIndexes(ByteArray parentId, ByteArray entityId, byte[] key, params Index[] indexes);
        void AppendScoreIndex(ByteArray parentId, ByteArray entityId, byte[] key, long score, IndexLevel indexLevel, OrderType orders);

        void Remove(ByteArray parentId, ByteArray entityId);
        void Remove(ByteArray parentId, ByteArray[] entityIds);
    }
}
