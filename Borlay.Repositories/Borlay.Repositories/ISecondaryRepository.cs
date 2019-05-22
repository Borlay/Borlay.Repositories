using Borlay.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Repositories
{
    public interface ISecondaryRepository : ICreateTransaction<ISecondaryTransaction>
    {
        byte[] GetValue(ByteArray parentId, ByteArray entityId);

        KeyValuePair<byte[], byte[]>[] GetValues(ByteArray parentId, ByteArray[] entityIds);
        IEnumerable<KeyValuePair<byte[], byte[]>> GetValues(ByteArray parentId, bool distinct = false);
        IEnumerable<KeyValuePair<byte[], byte[]>> GetValues(ByteArray parentId, OrderType orderType, bool distinct = false);
        IEnumerable<KeyValuePair<byte[], byte[]>> GetValues(OrderType orderType, bool distinct = false);

        bool Contains(ByteArray parentId, ByteArray entityId);
    }
}
