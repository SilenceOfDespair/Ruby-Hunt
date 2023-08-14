using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmor : MonoBehaviour
{
    public GameObject armor;
    public GameObject armorFinal;
    public static int playerArmorUpgrades;
    public static int playerArmor = 0;
    public static bool armorFinalOn;

    void Start()
    {
        playerArmorUpgrades = PlayerPrefs.GetInt("BoughtArmor");
        if (playerArmorUpgrades == 2)
        {
            playerArmor = 1;
            armorFinalOn = true;
        }
    }
    void Update()
    {
            ArmorDamage();
    }

    void ArmorDamage()
    {
        if (playerArmor == 0)
        {
            armor.SetActive(false);
        }
        if (playerArmor == 1 && armorFinalOn == false)
        {
            armor.SetActive(true);
        }
    }
}
