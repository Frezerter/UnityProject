using System.Collections;
using System.Collections.Generic;
using System.Threading;
//using UnityEditorInternal;
using UnityEngine;
using System;

public class Collectible : MonoBehaviour
{
    TMPro.TMP_Text Text;

    private int I = 0;

    private void Awake()
    {
        Text = GetComponent<TMPro.TMP_Text>();
    }

    private void OnEnable() => Coin.OnCollected += OnCollectibleCollected;
    private void OnDisable() => Coin.OnCollected -= OnCollectibleCollected;
    
    


    void OnCollectibleCollected()
    {
        Text.text = (++I).ToString();
    }


}
