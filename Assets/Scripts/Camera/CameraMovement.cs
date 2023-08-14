using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public static float cameraSpeed = 15f;

    void Update()
    {
        if (PlayerMovement.canMove == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * cameraSpeed, Space.World);
        }
    }
}
