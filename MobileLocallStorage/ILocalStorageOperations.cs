using System;
using System.Collections.Generic;
using System.Text;

namespace MobileLocallStorage
{
    interface ILocalStorageOperations<T>
    {
        T GetLatestAndUpdate(string key, IObserver<T> observer);

        T GetLocal();

        void ClearCache();

    }
}
