using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketSpawner_Felix : MonoBehaviour
{
    public GameObject CollisionCb;
    public GameObject TriggerCb;

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnColl();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpawnTrig();
        }
    }
    public void SpawnColl()
    {
        Instantiate(CollisionCb, transform);
    }
    public void SpawnTrig()
    {
        Instantiate(TriggerCb, transform);
    }
}
