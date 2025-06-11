using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class GameObjectColorChanger_Aryan : MonoBehaviour
{
    public GameObject obj;
    public XRGrabInteractable XRGrabInteractable;
    // Awake runs once at the beginning play (only once)
    private void Awake()
    {
        Debug.Log("Awake");
        XRGrabInteractable.selectEntered.AddListener(OnGrab);
        XRGrabInteractable.selectExited.AddListener(OnRelease);
        

    }
    public void showNumber(int num)
    {
        Debug.Log(num);
    }
    public void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("On grabbed");
    }
    public void OnRelease(SelectExitEventArgs args)
    {
        Debug.Log("On grabbed");
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
