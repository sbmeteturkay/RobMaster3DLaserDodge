using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player Bodys")]
    [SerializeField] GameObject ragDoll;
    [SerializeField] GameObject dublor;
    [SerializeField] PlayerMove playerMove;
    [Header("UI")]
    [SerializeField] GameObject finishPanel;


    [Header("Laser Touched")]
    public static int touchingLaser=0;
    private void Start()
    {
        SlowArea.TimeSlow += SlowArea_TimeSlow;
        FinishLine.Finished += FinishLine_Finished;
        touchingLaser = 0;
    }

    private void FinishLine_Finished()
    {
        finishPanel.SetActive(true);
    }

    private void SlowArea_TimeSlow(bool slow, bool player)
    {
        if (slow)
        {
            SlowTime();
        }
        else 
        {
            NormalTime();
            touchingLaser = 0;
        }
        if (player)
        {
            OpenPhysicsBody(slow);
        }
    }

    void NormalTime()
    {
       playerMove.movementSpeed = playerMove.defaultSpeed;
    }
   void SlowTime()
    {
        playerMove.movementSpeed /= playerMove.movementSpeed;
    }
    void OpenPhysicsBody(bool b)
    {
        dublor.SetActive(!b);
        ragDoll.SetActive(b);
    }
    public void MovePlayer(bool b)
    {
        PlayerMove.shouldMove = b;
    }
}
