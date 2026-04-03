using UnityEngine;

namespace Assets._Project.Scripts.Utils
{
    public struct Pool<T> where T : Behaviour
    {
        private readonly StructStack<T> _pool;

        private readonly T _prefab;

        public Pool(T prefab)
        {
            _prefab = prefab;
            _pool = new StructStack<T>(100);
        }

        public T Get()
        {
            if (_pool.Count == 0)
            {
                T pooledObject = Object.Instantiate(_prefab);
                return pooledObject;
            }

            return _pool.Pop();
        }

        public void Push(T @object)
        {
            _pool.Push(@object);
        }

        public void Clear() =>
            _pool.Clear();
    }
}