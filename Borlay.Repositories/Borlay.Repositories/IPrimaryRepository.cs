using Borlay.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Repositories
{
    public interface IPrimaryRepository : ICreateTransaction<IPrimaryTransaction>
    {
        byte[] Get(ByteArray entityId);
        KeyValuePair<ByteArray, byte[]>[] Get(ByteArray[] entityIds);

        IEnumerable<byte[]> Get();
        IEnumerable<byte[]> Get(OrderType orderType);

        bool Contains(ByteArray entityId);
    }
}
