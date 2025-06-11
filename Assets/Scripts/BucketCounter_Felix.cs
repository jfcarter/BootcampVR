using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketCounter_Felix : MonoBehaviour
{
    public int trigCount;
    public int collCount;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On Trigger Enter");
        trigCount++;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("On Trigger Exit");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On Collision Enter");
        collCount++;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("On Collision Exit");
    }
}
