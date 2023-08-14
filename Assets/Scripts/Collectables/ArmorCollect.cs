using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorCollect : MonoBehaviour
{
    public AudioSource armorFX;

    void Update()
    {
        if (PlayerArmor.playerArmorUpgrades == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (PlayerArmor.playerArmorUpgrades > 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    void OnTriggerEnter(Collider armor)
    {
        armorFX.Play();
        this.gameObject.SetActive(false);
        if (PlayerArmor.playerArmorUpgrades > 0 && PlayerArmor.playerArmor < 1) 
        { 
            PlayerArmor.playerArmor += 1;
        }
            OverallScore.scoreCount += 100;
    }
}
