using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OverallScore : MonoBehaviour
{
    public static int scoreCount;
    public GameObject ingameScoreDisplay;
    public GameObject scoreDisplayToHide;
    public GameObject endScoreDisplay;

    void Update()
    {
        ingameScoreDisplay.GetComponent<TMP_Text>().text = "" + scoreCount;
        endScoreDisplay.GetComponent<TMP_Text>().text = "" + scoreCount;
        HideScoreCount();
    }

    void HideScoreCount()
    {
        if (ObstacleCollision.UItoHide == true)
        {
            scoreDisplayToHide.SetActive(false);
        }
        if (ObstacleCollision.UItoHide == false)
        {
            scoreDisplayToHide.SetActive(true);
        }
    }
}
