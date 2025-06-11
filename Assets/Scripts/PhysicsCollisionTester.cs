using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCollisionTester : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On Trigger Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("On Trigger Exit");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On Collision Enter");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("On Collision Exit");
    }
}
