using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinModel;
    public float AlifeTime;

    void Update()
    {
        var position = new Vector3(UnityEngine.Random.Range(-15, 15), 1, UnityEngine.Random.Range(-15, 15));
        if (UnityEngine.Random.Range(0, 500) < 1)
        {
            Instantiate(CoinModel, position, Quaternion.identity);
        }
    }
}
