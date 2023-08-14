using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelChanger : MonoBehaviour
{
    public Button startButton;
    public Button shopButton;
    public Button exitButton;
    public Button scoreButton;
    public Button returnButton;
    public Button returnButtonShop;
    public GameObject mainMenu;
    public GameObject scoreMenu;
    public GameObject shopMenu;


    void Start()
    {
        Button btn1 = startButton.GetComponent<Button>();
        btn1.onClick.AddListener(StartOnClick);
        Button btn2 = exitButton.GetComponent<Button>();
        btn2.onClick.AddListener(ExitOnClick);
        Button btn3 = scoreButton.GetComponent<Button>();
        btn3.onClick.AddListener(ScoreOnClick);
        Button btn4 = returnButton.GetComponent<Button>();
        btn4.onClick.AddListener(ReturnOnClick);
        Button btn5 = shopButton.GetComponent<Button>();
        btn5.onClick.AddListener(ShopOnClick);
        Button btn6 = returnButtonShop.GetComponent<Button>();
        btn6.onClick.AddListener(ReturnOnClick);
    }

    void StartOnClick()
    {
        SceneManager.LoadScene("GameScene");
        PlayerMovement.canMove = false;
        ObstacleCollision.levelGen = true;
        ObstacleCollision.UItoHide = true;
        ObstacleCollision.exitTrue = false;
        ShopControl.boughtHealth = PlayerPrefs.GetInt("BoughtHealth");
    }

    void ScoreOnClick()
    {
        mainMenu.SetActive(false);
        scoreMenu.SetActive(true);
    }

    void ReturnOnClick()
    {
        mainMenu.SetActive(true);
        scoreMenu.SetActive(false);
        shopMenu.SetActive(false);
    }

    void ExitOnClick()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    void ShopOnClick()
    {
        mainMenu.SetActive(false);
        shopMenu.SetActive(true);
    }


}
