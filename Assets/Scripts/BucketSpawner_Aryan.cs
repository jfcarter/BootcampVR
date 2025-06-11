using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketSpawner_Aryan : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(obj);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(obj2);
        }
    }
}
