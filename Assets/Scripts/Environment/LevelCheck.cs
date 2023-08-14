using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheck : MonoBehaviour
{
    void OnTriggerEnter(Collider lev)
    {
        if (lev.gameObject.name == "Player")
        {
            OverallScore.scoreCount += 100;
        }
    }
}
