using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling<T> : MonoBehaviour where T : Component
{
    public void InitPool(int size, T prefab, List<T> list)
    {
        for (int i = 0; i < size; i++)
        {
            T obj = Instantiate(prefab, transform);
            obj.gameObject.SetActive(false);
            list.Add(obj);
        }
    }

    public T GetObjectInPool(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (!list[i].gameObject.activeInHierarchy)
            {
                return list[i];
            }
        }

        return null;
    }

    public void SetActivePooledObject(Vector3 origin, List<T> list)
    {
        T obj = GetObjectInPool(list);

        if (obj != null)
        {
            obj.transform.position = origin;
            obj.gameObject.SetActive(true);
        }
    }
}
