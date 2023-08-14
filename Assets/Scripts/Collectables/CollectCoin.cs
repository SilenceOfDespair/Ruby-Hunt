using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CoinControl.coinCount += 1;
        OverallScore.scoreCount += 10;
        this.gameObject.SetActive(false);
        if (BoltCollect.speedUpOn == true)
        {
            CoinControl.coinCount += 1;
            OverallScore.scoreCount += 10;
        }
    }
}
