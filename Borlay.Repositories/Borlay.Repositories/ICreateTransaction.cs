using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Repositories
{
    public interface ICreateTransaction<out T> where T : ITransaction
    {
        T CreateTransaction();
    }

    public interface ICommit
    {
        Task Commit();
    }

    public interface ITransaction : ICommit, IDisposable
    {
    }
}
