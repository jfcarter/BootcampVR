using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectColorChanger_Felix : MonoBehaviour
{
    public GameObject obj;

    // Runs once at the beginning of play (only once)
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
        // Debug.Log("FixedUpdate");
    }
    // Called after update and rendering
    private void LateUpdate()
    {
        // Debug.Log("LateUpdate");
    }
    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeGameObjectColor();
        }
    }

    public void ChangeGameObjectColor()
    {
        Debug.Log("Changed Color");
        obj.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}
