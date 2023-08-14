using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FreezingObstacle: MonoBehaviour
{
    public static int playerFrostLevel;
    public GameObject Snowman;
    public GameObject FreezeStage1;
    public GameObject FreezeStage2;
    public GameObject FreezeStage3;
    public AudioSource freezeSound;

    void OnTriggerEnter(Collider frost)
    {
        playerFrostLevel += 1;
        Snowman.SetActive(false);
        freezeSound.Play();
    }

    void Update()
    {
        if (playerFrostLevel == 1)
        {
            FreezeStage1.SetActive(true);
        }
        if (playerFrostLevel == 2)
        {
            FreezeStage1.SetActive(false);
            FreezeStage2.SetActive(true);
        }
        if (playerFrostLevel == 3)
        {
            FreezeStage3.SetActive(true);
            FreezeStage2.SetActive(false);
            PlayerHealth.playerHealth = 0;
        }
    }

}
