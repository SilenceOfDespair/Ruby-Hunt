using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCollect : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CoinControl.iceCount += 1;
        OverallScore.scoreCount += 200;
        this.gameObject.SetActive(false);
        if (BoltCollect.speedUpOn == true)
        {
            CoinControl.iceCount += 1;
            OverallScore.scoreCount += 400;
        }
    }
}
