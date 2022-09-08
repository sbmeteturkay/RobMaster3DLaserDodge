using System;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public static event Action Finished;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Finished?.Invoke();
        }
    }
}
