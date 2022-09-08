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
    }
    void Update()
    {
        if(shouldMove)
            transform.position += movementSpeed * Time.deltaTime * Vector3.down;
    }
}
