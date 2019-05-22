using Borlay.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Repositories
{
    public interface IPrimaryRepository : ICreateTransaction<IPrimaryTransaction>
    {
        byte[] GetValue(ByteArray entityId);

        KeyValuePair<byte[], byte[]>[] GetValues(ByteArray[] entityIds);
        IEnumerable<KeyValuePair<byte[], byte[]>> GetValues(bool distinct = false);
        IEnumerable<KeyValuePair<byte[], byte[]>> GetValues(OrderType orderType, bool distinct = false);

        bool Contains(ByteArray entityId);
    }
}
