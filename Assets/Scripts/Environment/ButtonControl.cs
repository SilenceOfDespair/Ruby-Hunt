using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public Button stopButton;
    public Button continueButton;
    public Button exitButton;
    public GameObject pauseMenu;
    public GameObject countDown1;
    public GameObject countDown2;
    public GameObject countDown3;
    public AudioSource numSound;

    void Update()
    {
        if (LevelStarter.stopEnabled == true)
        {
            stopButton.gameObject.SetActive(true);
        }
        else if (LevelStarter.stopEnabled == false)
        {
            stopButton.gameObject.SetActive(false);
        }
    }

    void Start()
    {
        Button stopbtn = stopButton.GetComponent<Button>();
        stopbtn.onClick.AddListener(StopOnClick);
        Button conbtn = continueButton.GetComponent<Button>();
        conbtn.onClick.AddListener(ContinueOnClick);
        Button exitbtn = exitButton.GetComponent<Button>();
        exitbtn.onClick.AddListener(ExitOnClick);
    }

    void StopOnClick()
    {
        pauseMenu.SetActive(true);
        ObstacleCollision.UItoHide = true;
        PlayerMovement.canMove = false;
        ObstacleCollision.levelGen = false;
    }

    IEnumerator Continue()
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
        PlayerMovement.canMove = true; 
        ObstacleCollision.levelGen = true;
    }

    void ContinueOnClick()
    {
        pauseMenu.SetActive(false);
        ObstacleCollision.UItoHide = false;
        StartCoroutine(Continue());
    }

    void ExitOnClick()
    {
        SceneManager.LoadScene("MenuScene");
        ObstacleCollision.exitTrue = true;
        CoinControl.coinCount = 0;
        LevelCount.levelCount = 0;
        ObstacleCollision.UItoHide = false;
        LevelStarter.stopEnabled = false;
    }

    
}
