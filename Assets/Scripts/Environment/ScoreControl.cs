using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreControl : MonoBehaviour
{
    public GameObject coinScoreDisplay;
    public GameObject overallScoreDisplay;
    public GameObject lastScoreDisplay;
    public GameObject rubyLastScoreDisplay;
    public static int coinHighScore;
    public static int overallHighScore;
    public static int rubyLastScore;
    public static int lastScore;
    public Button yesReset;
    public Button noReset;
    public Button resetButton;
    public GameObject scoreWindow;
    public GameObject resetWindow;

    void Start()
    {
        Button resbtn = resetButton.GetComponent<Button>();
        resbtn.onClick.AddListener(ToReset);
        Button yesBtn = yesReset.GetComponent<Button>();
        yesBtn.onClick.AddListener(ResetAllScore);
        Button noBtn = noReset.GetComponent<Button>();
        noBtn.onClick.AddListener(ReturnToScore);
        coinHighScore = PlayerPrefs.GetInt("highScore");
        coinScoreDisplay.GetComponent<TMP_Text>().text = "" + coinHighScore;
        overallHighScore = PlayerPrefs.GetInt("overallHighScore");
        overallScoreDisplay.GetComponent<TMP_Text>().text = "" + overallHighScore;
        rubyLastScore = PlayerPrefs.GetInt("lastRubyScore");
        rubyLastScoreDisplay.GetComponent<TMP_Text>().text = "" + rubyLastScore;
        lastScore = PlayerPrefs.GetInt("lastScore");
        lastScoreDisplay.GetComponent<TMP_Text>().text = "" + lastScore;
    }

    void ToReset()
    {
        scoreWindow.SetActive(false);
        resetWindow.SetActive(true);
    }

    void ResetAllScore()
    {
        coinHighScore = 0;
        overallHighScore = 0;
        ScoreSave.highScore = 0;
        ScoreSave.overallHighScore = 0;
        PlayerPrefs.SetInt("highScore", 0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("overallHighScore", 0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lastRubyScore", 0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lastScore", 0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("RubyBalance", 0);
        PlayerPrefs.SetInt("IceBalance", 0);
        PlayerPrefs.SetInt("FireBalance", 0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("BoughtHealth", 0);
        PlayerPrefs.SetInt("BoughtArmor", 0);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MenuScene");
    }

    void ReturnToScore()
    {
        scoreWindow.SetActive(true);
        resetWindow.SetActive(false);
    }

}
