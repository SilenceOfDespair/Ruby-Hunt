using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject heart;
    public GameObject fullHeart;
    public GameObject fullHeart1;
    public GameObject fullHeart2;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int playerHealth = 1;
    public static int playerHealthUpgrades;
    
    void Start()
    {
        playerHealthUpgrades = PlayerPrefs.GetInt("BoughtHealth");
        if (playerHealthUpgrades == 0)
        {
            fullHeart.SetActive(false);
            fullHeart1.SetActive(false);
            fullHeart2.SetActive(false);
        }
        if (playerHealthUpgrades == 1)
        {
            playerHealth = 2;
            fullHeart.SetActive(true);
            fullHeart1.SetActive(false);
            fullHeart2.SetActive(false);
        }
        if (playerHealthUpgrades == 2)
        {
            playerHealth = 3;
            fullHeart.SetActive(true);
            fullHeart1.SetActive(true);
            fullHeart2.SetActive(false);
        }
        if (playerHealthUpgrades == 3)
        {
            playerHealth = 4;
            fullHeart.SetActive(true);
            fullHeart1.SetActive(true);
            fullHeart2.SetActive(true);

        }
    }
    void Update()
    {
            HealthDamage();
    }
    void HealthDamage()
    {
        if (playerHealth == 4)
        {
            heart3.SetActive(true);
        }
        if (playerHealth == 3)
        {
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        if (playerHealth == 2)
        {
            heart.SetActive(true);
            heart1.SetActive(true);
            heart2.SetActive(false);
        }
        if (playerHealth == 1)
        {
            heart1.SetActive(false);
        }
        if (playerHealth == 0)
        {
            heart.SetActive(false);
        }
    }
}
