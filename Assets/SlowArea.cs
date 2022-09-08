using System;
using UnityEngine;

public class SlowArea : MonoBehaviour
{
    public static event Action<bool> TimeSlow;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.CompareTag("Player"))
        {
            TimeSlow?.Invoke(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TimeSlow?.Invoke(false);
        }
    }
}
