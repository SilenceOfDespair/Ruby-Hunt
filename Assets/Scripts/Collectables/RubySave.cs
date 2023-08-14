using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubySave : MonoBehaviour
{
    public static int rubyBalance;
    public static int rubyRunBalance;
    public static int iceBalance;
    public static int iceRunBalance; 
    public static int fireBalance;
    public static int fireRunBalance;

    void Start()
    {
        iceBalance = PlayerPrefs.GetInt("IceBalance");
        fireBalance = PlayerPrefs.GetInt("FireBalance");
        rubyBalance = PlayerPrefs.GetInt("RubyBalance");
        Debug.Log(rubyBalance);
    }

    void Update()
    {
        if (ObstacleCollision.balanceSave == true)
        {
            iceRunBalance = CoinControl.iceCount;
            fireRunBalance = CoinControl.fireCount;
            rubyRunBalance = CoinControl.coinCount;
            rubyBalance += rubyRunBalance;
            iceBalance += iceRunBalance;
            fireBalance += fireRunBalance;
            PlayerPrefs.SetInt("RubyBalance", rubyBalance);
            PlayerPrefs.SetInt("IceBalance", iceBalance);
            PlayerPrefs.SetInt("FireBalance", fireBalance);
            PlayerPrefs.Save();
            rubyRunBalance = 0;
            iceRunBalance = 0;
            fireRunBalance = 0;
            Debug.Log(rubyBalance);
            ObstacleCollision.balanceSave = false;
        }
    }

}
