using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject theCamera;
    public GameObject gameOver;
    public GameObject thePlayer;
    public GameObject EndText5;
    public GameObject EndText4;
    public GameObject EndText3;
    public GameObject EndText2;
    public GameObject EndText1;
    public GameObject EndText0;
    public AudioSource hitSound;
    public int secNum = 1;
    public static bool playerHit = false;
    public static bool timeEnd = false;
    public static bool levelGen = true;
    public static bool UItoHide = false;
    public static bool exitTrue = false;
    public static bool saveScore = false;
    public static bool exitEnabler = false;
    public static bool balanceSave = false;


    void Update()
    {
        StartCoroutine(timeToEnd());
        newSceneStart();
        backToMenu();
        GameEnd();
    }

    void backToMenu()
    {
        if (Input.touchCount > 0 && exitEnabler == true)
        {
            SceneManager.LoadScene("MenuScene");
            CoinControl.coinCount = 0;
            OverallScore.scoreCount = 0;
            exitTrue = true;
            saveScore = false;
            exitEnabler = false;
        }
    }

    void newSceneStart()
    {
        if (timeEnd == true && exitTrue == false)
        {
            SceneManager.LoadScene("GameScene");
            timeEnd = false;
            levelGen = true;
            EndText0.SetActive(false);
            CoinControl.coinCount = 0;
            OverallScore.scoreCount = 0;
            UItoHide = false;
            saveScore = false;
            exitEnabler = false;
        }
    }

    IEnumerator timeToEnd()
    {
        if(playerHit == true)
        {
            exitEnabler = true;
            Debug.Log("Started");
            levelGen = false;
            playerHit = false;
            EndText5.SetActive(true);
            yield return new WaitForSeconds(1);
            EndText5.SetActive(false);
            EndText4.SetActive(true);
            yield return new WaitForSeconds(1);
            EndText4.SetActive(false);
            EndText3.SetActive(true);
            yield return new WaitForSeconds(1);
            EndText3.SetActive(false);
            EndText2.SetActive(true);
            yield return new WaitForSeconds(1);
            EndText2.SetActive(false);
            EndText1.SetActive(true);
            yield return new WaitForSeconds(1);
            EndText1.SetActive(false);
            EndText0.SetActive(true);
            Debug.Log("5 sec");
            timeEnd = true;
            PlayerMovement.canMove = false;
        }
    }

    void GameEnd()
    {
        if (PlayerHealth.playerHealth == 0)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMovement>().enabled = false;
            theCamera.GetComponent<CameraMovement>().enabled = false;
            balanceSave = true;
            gameOver.SetActive(true);
            LevelStarter.stopEnabled = false;
            saveScore = true;
            playerHit = true;
            UItoHide = true;
            FreezingObstacle.playerFrostLevel = 0;
            if (PlayerHealth.playerHealthUpgrades == 0)
            {
                PlayerHealth.playerHealth = 1;
            }
            else if (PlayerHealth.playerHealthUpgrades == 1)
            {
                PlayerHealth.playerHealth = 2;
            }
            else if (PlayerHealth.playerHealthUpgrades == 2)
            {
                PlayerHealth.playerHealth = 3;
            }
            else if (PlayerHealth.playerHealthUpgrades == 3)
            {
                PlayerHealth.playerHealth = 4;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (BoltCollect.speedUpOn == false && PlayerArmor.playerArmor == 0)
        {
            PlayerHealth.playerHealth -= 1;
        }
        if (BoltCollect.speedUpOn == false && PlayerArmor.playerArmor != 0)
        {
            PlayerArmor.playerArmor -= 1;
            PlayerArmor.armorFinalOn = false;
        }
        hitSound.Play();
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
