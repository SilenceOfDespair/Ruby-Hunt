using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public AudioSource heartFX;

    void OnTriggerEnter(Collider other)
    {
        heartFX.Play();
        this.gameObject.SetActive(false);
        if(ShopControl.boughtHealth == 1 && PlayerHealth.playerHealth < 2)
        {
            PlayerHealth.playerHealth += 1;
        }
        if (ShopControl.boughtHealth == 2 && PlayerHealth.playerHealth < 3)
        {
            PlayerHealth.playerHealth += 1;
        }
        if (ShopControl.boughtHealth == 3 && PlayerHealth.playerHealth < 3)
        {
            PlayerHealth.playerHealth += 1;
        }
        OverallScore.scoreCount += 200;
    }
}
