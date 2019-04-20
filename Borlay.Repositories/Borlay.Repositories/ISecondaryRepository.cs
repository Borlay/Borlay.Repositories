using Borlay.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Repositories
{
    public interface ISecondaryRepository : ICreateTransaction<ISecondaryTransaction>
    {
        byte[] Get(ByteArray parentId, ByteArray entityId);
        KeyValuePair<ByteArray, byte[]>[] Get(ByteArray parentId, ByteArray[] entityIds);

        IEnumerable<byte[]> Get(ByteArray parentId);
        IEnumerable<byte[]> Get(ByteArray parentId, OrderType orderType);
        IEnumerable<byte[]> Get(OrderType orderType);

        bool Contains(ByteArray parentId, ByteArray entityId);
    }
}
