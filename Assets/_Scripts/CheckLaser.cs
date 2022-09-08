using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLaser : MonoBehaviour
{
    [SerializeField] MeshRenderer sphereMesh;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Laser"))
        {
            sphereMesh.material.color = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Laser"))
        {
            sphereMesh.material.color = Color.green;
        }
    }
}
