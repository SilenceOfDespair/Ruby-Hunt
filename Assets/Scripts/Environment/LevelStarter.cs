using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown1;
    public GameObject countDown2;
    public GameObject countDown3;
    public AudioSource goSound;
    public AudioSource numSound;
    public static bool stopEnabled = false;

    void Start()
    {
        if (PlayerHealth.playerHealthUpgrades == 0)
        {
            PlayerHealth.playerHealth = 1;
        }
        else if (PlayerHealth.playerHealthUpgrades == 1)
        {
            PlayerHealth.playerHealth = 2;
        }
        StartCoroutine(CountSequence());
    }

   IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        numSound.Play();
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1);
        numSound.Play();
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1);
        numSound.Play();
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1);
        goSound.Play();
        ObstacleCollision.UItoHide = false;
        stopEnabled = true;
        PlayerMovement.canMove = true;

    }
}
