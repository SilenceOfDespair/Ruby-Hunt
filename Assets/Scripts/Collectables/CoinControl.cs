using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CoinControl : MonoBehaviour
{
    public static int coinCount;
    public static int iceCount;
    public static int fireCount;
    public GameObject coinCountDisplay;
    public GameObject endCoinCountDisplay;
    public GameObject coinDisplayToHide;

    void Update()
    {
        coinCountDisplay.GetComponent<TMP_Text> ().text = "" + coinCount;
        endCoinCountDisplay.GetComponent<TMP_Text>().text = "" + coinCount;
        HideCoinCount();
    }


    void HideCoinCount()
    {
        if (ObstacleCollision.UItoHide == true) 
        {
            coinDisplayToHide.SetActive(false);
        }
        if (ObstacleCollision.UItoHide == false)
        {
            coinDisplayToHide.SetActive(true);
        }
    }
}
