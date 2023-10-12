using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static event Action OnCollected;

    [SerializeField]
    private Vector3 Rotation;

    [SerializeField]
    private float speed = 10f;

    public GameObject CoinModel;


    void Update()
    {
        transform.Rotate(Rotation * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        OnCollected?.Invoke();
        Destroy(CoinModel);
       
    }
    


}
