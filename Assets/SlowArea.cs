using System;
using UnityEngine;

public class SlowArea : MonoBehaviour
{
    public static event Action<bool,bool> TimeSlow;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            TimeSlow?.Invoke(true,true);
        }
        if (other.CompareTag("Handle"))
        {
            print("++++++++++");
            GameManager.touchingLaser++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TimeSlow?.Invoke(false,true);
        }
        if (other.CompareTag("Handle"))
        {
            print("-----------");
            GameManager.touchingLaser--;
            if (GameManager.touchingLaser == 0)
            {
                TimeSlow?.Invoke(false,false);
            }
        }
    }
}
