using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float defaultSpeed = 1f;
    public float movementSpeed;
    //we call this on game manager while starting game by clicking panel from start canvas
    public static bool shouldMove = false;
    private void Start()
    {
        movementSpeed = defaultSpeed;
        shouldMove = false;
    }
    void FixedUpdate()
    {
        if(shouldMove)
            transform.position += movementSpeed * Time.fixedDeltaTime * Vector3.down;
    }
}
