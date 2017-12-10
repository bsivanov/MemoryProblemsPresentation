using System;

namespace PoolImplementation
{
    interface IPoolableObject : IDisposable
    {
        int Size { get; }
        void Reset();
        void SetPoolManager(PoolManager poolManager);
    }
}
