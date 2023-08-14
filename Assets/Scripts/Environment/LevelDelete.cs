using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDelete : MonoBehaviour
{
    public GameObject dsection;
    public float dsec = 5;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(dsection, dsec);
        }
        LevelGenerator.levelCheck += 1;
    }
  
}
