using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project.Scripts.Utils
{
    public class PoolObject<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private Transform _container;

        private Queue<T> _pool;

        private void Awake() =>
            _pool = new Queue<T>();

        public T Push(T @object)
        {
            if (_pool.Count == 0)
            {
                T pooledGameObject = Instantiate(@object, _container);
                return pooledGameObject;
            }

            @object.gameObject.SetActive(true);
            _pool.Dequeue();
            return _pool.Dequeue();
        }

        public void Pull(T @object)
        {
            _pool.Dequeue();
            @object.gameObject.SetActive(false);
        }

        public void Clear() =>
            _pool.Clear();
    }
}