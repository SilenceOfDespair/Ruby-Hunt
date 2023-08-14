using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltCollect : MonoBehaviour
{
    public AudioSource boltFX;
    public static bool speedUpOn = false;
    public static bool boltTaken = false;

    void OnTriggerEnter(Collider other)
    {
        if (speedUpOn)
        {
            OverallScore.scoreCount += 1000;
            this.gameObject.SetActive(false);
        }
        else
        {
            boltFX.Play();
            this.gameObject.SetActive(false);
            Debug.Log("true");
            boltTaken = true;
            speedUpOn = true;
            PlayerMovement.speed += 5;
            CameraMovement.cameraSpeed += 5;
        }
    }
    void Update()
    {
        if (boltTaken == true)
        {
            StartCoroutine(SpeedUp());
            Debug.Log("false");
        }
    }
    IEnumerator SpeedUp()
    {
        boltTaken = false;
        yield return new WaitForSeconds(5);
        PlayerMovement.speed -= 5;
        CameraMovement.cameraSpeed -= 5;
        Debug.Log("5sec");
        speedUpOn = false;
    }

}
