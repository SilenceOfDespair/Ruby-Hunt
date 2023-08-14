using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour
{
    public GameObject rubyBalanceDisplay;
    public GameObject iceBalanceDisplay;
    public GameObject fireBalanceDisplay;
    public Button buyHealthButton;
    public Button buyArmorButton;
    public static int rubyCurrentBalance;
    public static int iceCurrentBalance;
    public static int fireCurrentBalance;
    public static int boughtHealth;
    public static int boughtHealth1;
    public static int boughtArmor;
    public static int boughtArmor1;
    public GameObject healthWindow;
    public GameObject healthWindow1;
    public GameObject healthWindow2;
    public GameObject armorWindow;
    public GameObject armorWindow1;


    void Start()
    {
        boughtArmor = PlayerPrefs.GetInt("BoughtArmor");
        boughtHealth = PlayerPrefs.GetInt("BoughtHealth");
        Debug.Log(boughtHealth);
        rubyCurrentBalance = PlayerPrefs.GetInt("RubyBalance");
        iceCurrentBalance = PlayerPrefs.GetInt("IceBalance");
        fireCurrentBalance = PlayerPrefs.GetInt("FireBalance");
        rubyBalanceDisplay.GetComponent<TMP_Text>().text = "" + rubyCurrentBalance;
        iceBalanceDisplay.GetComponent<TMP_Text>().text = "" + iceCurrentBalance;
        fireBalanceDisplay.GetComponent<TMP_Text>().text = "" + fireCurrentBalance;
        Button hpbuy = buyHealthButton.GetComponent<Button>();
        hpbuy.onClick.AddListener(HealthBuy);
        Button arbuy = buyArmorButton.GetComponent<Button>();
        arbuy.onClick.AddListener(ArmorBuy);
        if (boughtHealth == 1)
        {
            healthWindow2.SetActive(false);
            healthWindow.SetActive(false);
            healthWindow1.SetActive(true);
        }
        if (boughtHealth == 0)
        {
            healthWindow.SetActive(true);
            healthWindow1.SetActive(false);
            healthWindow2.SetActive(false);
        }
        if (boughtHealth == 2)
        {
            healthWindow.SetActive(false);
            healthWindow1.SetActive(false);
            healthWindow2.SetActive(true);
        }
        if (boughtHealth == 3)
        {
            healthWindow.SetActive(false);
            healthWindow1.SetActive(false);
            healthWindow2.SetActive(false);
            armorWindow.SetActive(true);
        }
        if (boughtArmor == 1)
        {
            armorWindow.SetActive(false);
            armorWindow1.SetActive(true);
        }
        if (boughtArmor == 2)
        {
            armorWindow1.SetActive(false);
        }
        Debug.Log(boughtHealth);
    }

    void HealthBuy()
    {
        if (boughtHealth == 0 && rubyCurrentBalance >= 20)
        {
            boughtHealth1 += 1;
            rubyCurrentBalance -= 20;
            PlayerPrefs.SetInt("RubyBalance", rubyCurrentBalance);
            PlayerPrefs.SetInt("BoughtHealth", boughtHealth1);
            Debug.Log(boughtHealth);
            SceneManager.LoadScene("MenuScene");
        }
        else if (boughtHealth == 1 && rubyCurrentBalance >= 40)
        {
            boughtHealth1 += 1;
            rubyCurrentBalance -= 40;
            PlayerPrefs.SetInt("RubyBalance", rubyCurrentBalance);
            PlayerPrefs.SetInt("BoughtHealth", boughtHealth1);
            Debug.Log(boughtHealth);
            SceneManager.LoadScene("MenuScene");
        }
        else if (boughtHealth == 2 && rubyCurrentBalance >= 80 && iceCurrentBalance >= 2 && fireCurrentBalance >= 2)
        {
            boughtHealth1 += 1;
            rubyCurrentBalance -= 60;
            iceCurrentBalance -= 2;
            fireCurrentBalance -= 2;
            PlayerPrefs.SetInt("RubyBalance", rubyCurrentBalance);
            PlayerPrefs.SetInt("IceBalance", iceCurrentBalance);
            PlayerPrefs.SetInt("FireBalance", fireCurrentBalance);
            PlayerPrefs.SetInt("BoughtHealth", boughtHealth1);
            Debug.Log(boughtHealth);
            SceneManager.LoadScene("MenuScene");
        }
    }

    void ArmorBuy()
    {
        if (boughtHealth == 3 && rubyCurrentBalance >= 20 && boughtArmor == 0)
        {
            boughtArmor1 += 1;
            rubyCurrentBalance -= 20;
            PlayerPrefs.SetInt("RubyBalance", rubyCurrentBalance);
            PlayerPrefs.SetInt("BoughtArmor", boughtArmor1);
            Debug.Log(boughtArmor);
            SceneManager.LoadScene("MenuScene");
        }
        else if (boughtArmor == 1 && iceCurrentBalance >= 2 && fireCurrentBalance >= 2)
        {
            boughtArmor1 += 1;
            iceCurrentBalance -= 2;
            fireCurrentBalance -= 2;
            PlayerPrefs.SetInt("IceBalance", iceCurrentBalance);
            PlayerPrefs.SetInt("FireBalance", fireCurrentBalance);
            PlayerPrefs.SetInt("BoughtArmor", boughtArmor1);
            Debug.Log(boughtArmor);
            SceneManager.LoadScene("MenuScene");
        }
    }

    void HealthUpgrades()
    {
        PlayerPrefs.SetInt("HPupgrade0", 1);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("HPupgrade1", 2);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("HPupgrade2", 3);
        PlayerPrefs.Save();
    }

}
