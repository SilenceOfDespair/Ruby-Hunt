using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    public static int highScore;
    public static int overallHighScore;
    public static int lastScore;
    public static int lastRubyScore;

    void Update()
    {
        if (CoinControl.coinCount > highScore && ObstacleCollision.saveScore == true)
        {
            highScore = CoinControl.coinCount;
            PlayerPrefs.SetInt("highScore", highScore);
            PlayerPrefs.Save();
        }
        if (OverallScore.scoreCount > overallHighScore && ObstacleCollision.saveScore == true)
        {
            overallHighScore = OverallScore.scoreCount;
            PlayerPrefs.SetInt("overallHighScore", overallHighScore);
            PlayerPrefs.Save();
        }
        if (ObstacleCollision.saveScore == true)
        {
            lastScore = OverallScore.scoreCount;
            PlayerPrefs.SetInt("lastScore", lastScore);
            PlayerPrefs.Save();
        }
        if (ObstacleCollision.saveScore == true)
        {
            lastRubyScore = CoinControl.coinCount;
            PlayerPrefs.SetInt("lastRubyScore", lastRubyScore);
            PlayerPrefs.Save();
        }
    }
}
