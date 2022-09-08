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
    private void Start()
    {
        SlowArea.TimeSlow += SlowArea_TimeSlow;
        FinishLine.Finished += FinishLine_Finished;
    }

    private void FinishLine_Finished()
    {
        finishPanel.SetActive(true);
    }

    private void SlowArea_TimeSlow(bool obj)
    {
        if (obj)
        {
            OpenPhysicsBody(obj);
            SlowTime();
        }
        else
        {
            OpenPhysicsBody(obj);
            NormalTime();
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
