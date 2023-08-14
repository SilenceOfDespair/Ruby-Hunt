using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public CharacterController controller;

    static public bool canMove = false;

    public static float speed = 15f;
    public float sideSpeed = 10;

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    private bool playerLeft;
    private bool playerRight;

    void Update()
    {
        if (canMove == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
            CharacterPositionLeft();
            CharacterPositionRight();
            SwipeControl();
        }
    }
 
    void CharacterPositionRight()
    {
        if (transform.position.x == 4)
        {
            playerRight = true;
        }
        if (transform.position.x == 0)
        {
            playerRight = false;
        }
        if (transform.position.x == -4)
        {
            playerRight = false;
        }
    }
    void CharacterPositionLeft()
    {
        if (transform.position.x == -4)
        {
            playerLeft = true;
        }
        if (transform.position.x == 0)
        {
            playerLeft = false;
        }
        if (transform.position.x == 4)
        {
            playerLeft = false;
        }
    }
    void SwipeControl()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if (endTouchPosition.x < startTouchPosition.x && playerLeft == false)
            {
                    transform.position = new Vector3(transform.position.x -4, transform.position.y, transform.position.z);
            }
            if (endTouchPosition.x > startTouchPosition.x && playerRight == false)
            {
                    transform.position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
            }
        }
    }
}

