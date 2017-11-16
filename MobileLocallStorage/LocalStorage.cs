using System;

namespace MobileLocallStorage
{
    public class LocalStorageImplementation<T> : MobileLocallStorage.ILocalStorageOperations<T>
    {
        public T GetLatestAndUpdate() 
        {
            return default (T);
        }

        public T GetLocal()
        {
            return default(T);
        }

        public void ClearCache()
        {
          //Clear Cashe   
        }

        public T GetLatestAndUpdate(string key, IObserver<T> observer)
        {
            
        }
    }
}
