﻿using Borlay.Arrays;
using Borlay.Handling.Notations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Borlay.Repositories
{
    [NameScope("PrimaryRepository")]
    public interface IPrimaryRepository<T>
    {
        [IdAction(1)]
        Task Save(T entity);

        [IdAction(2)]
        Task<T> Get(ByteArray entityId);
    }

    public interface ISortedPrimaryRepository<T> : IPrimaryRepository<T>
    {
        [IdAction(3)]
        Task<T[]> Get(int skip, int take);
    }
}