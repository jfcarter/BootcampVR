using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSpawner_Felix : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }
    public void SpawnObject()
    {
        Instantiate(ObjectToSpawn, transform);
    }
}
