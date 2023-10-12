using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float PlayerScore = 0;
    public float ScoreGainingSpeed = 1;
    

    // Update is called once per frame
    void Update()
    {
        PlayerScore = (ScoreGainingSpeed + PlayerScore)*Time.time;
    }
}
