using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pooling
{
    public int MemberId;
    public GameObject prefab;
    public Transform parent;
    public int totalMember;
    public Queue<GameObject> pool;

    public void FillPool(int _MemberId)
    {
        MemberId = _MemberId;
        pool = new Queue<GameObject>();
        for (int i = 0; i < totalMember; i++)
        {
            GameObject newObject = Object.Instantiate(prefab, parent);
            newObject.AddComponent<PoolMember>().MemberId = MemberId;
            newObject.SetActive(false);
            pool.Enqueue(newObject);
        }
    }
    public GameObject CallMember(Vector3 _position)
    {
        GameObject call = pool.Dequeue();
        call.transform.position = _position;
        call.SetActive(true);
        return call;

    }
    public void AddPool(GameObject gameObject)
    {
        Debug.Log(gameObject.name + " , " + pool.Count);
        pool.Enqueue(gameObject);
        gameObject.SetActive(false);
    }
}
