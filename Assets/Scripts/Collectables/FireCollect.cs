using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollect : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CoinControl.fireCount += 1;
        OverallScore.scoreCount += 200;
        this.gameObject.SetActive(false);
        if (BoltCollect.speedUpOn == true)
        {
            CoinControl.fireCount += 1;
            OverallScore.scoreCount += 400;
        }
    }
}
