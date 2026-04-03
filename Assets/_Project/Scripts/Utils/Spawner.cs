using UnityEngine;

namespace Assets._Project.Scripts.Utils
{   
    public abstract class Spawner<T> : MonoBehaviour where T : Behaviour
    {
        [SerializeField] private T _prefab;

        private Pool<T> _pool;

        private void Awake() 
        {
            _prefab.DisableGameObject();
            _pool = new Pool<T>(_prefab);
        }

        public T Spawn(Vector3? position = null, Quaternion? rotation = null)
        {
            T @object = _pool.Get();
            OnSpawn(@object);

            @object.transform.position = position ?? @object.transform.position;
            @object.transform.rotation = rotation ?? @object.transform.rotation;
            return @object.EnableGameObject();
        }

        protected virtual void OnSpawn(T @object)
        {
            
        }

        public void Return(T @object)
        {
            OnReturn(@object);
            _pool.Push(@object.DisableGameObject());
        }

        protected virtual void OnReturn(T @object)
        {
            
        }
    }
}