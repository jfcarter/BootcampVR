using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectColorChanger_Aryan : MonoBehaviour
{
    public GameObject obj;
    // Awake runs once at the beginning play (only once)
    private void Awake()
    {
        Debug.Log("Awake");

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    // Runs every time the game object is enabled
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Runs every time the game object is disabled
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    // Runs when the object is destroyed
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    // Runs according to preset physics updates
    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate");
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeGameObjectColor();
        }
    }
    public void ChangeGameObjectColor()
    {
        Debug.Log("Change In Color");
        obj.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
    // Called after update and renderring
    private void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }
}
