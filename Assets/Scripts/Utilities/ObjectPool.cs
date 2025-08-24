using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    private readonly Queue<T> _pool = new Queue<T>();
    private readonly HashSet<T> _activeObjects = new HashSet<T>();
    private readonly T _prefab;
    private readonly Transform _parent;
    private readonly int _maxCount;

    public ObjectPool(T prefab, int initCount, Transform parent = null, int maxCount = 0)
    {
        _prefab = prefab;
        _parent = parent;
        _maxCount = maxCount;

        for (int i = 0; i < initCount; ++i)
        {
            var obj = CreateNewObj();
            ReturnObj(obj);
        }
    }

    private T CreateNewObj()
    {
        var obj = GameObject.Instantiate(_prefab, _parent);
        obj.gameObject.SetActive(false);
        return obj;
    }

    public T GetObj()
    {
        T obj = _pool.Count > 0 ? _pool.Dequeue() : CreateNewObj();

        obj.gameObject.SetActive(true);
        obj.transform.SetParent(null);

        _activeObjects.Add(obj);
        return obj;
    }

    public void ReturnObj(T obj)
    {
        if (_activeObjects.Contains(obj))
            _activeObjects.Remove(obj);

        if (_maxCount > 0 && _pool.Count >= _maxCount)
        {
            GameObject.Destroy(obj.gameObject);
            return;
        }

        obj.gameObject.SetActive(false);
        obj.transform.SetParent( _parent);

        _pool.Enqueue(obj);
    }

    public void ReturnAll()
    {
        foreach (var obj in new List<T>(_activeObjects))
        {
            ReturnObj(obj);
        }
        _activeObjects.Clear();
    }
}
