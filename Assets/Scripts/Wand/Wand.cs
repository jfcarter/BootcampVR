using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Wand : MonoBehaviour
{
    private XRIDefaultInputActions inputActions;

    public bool usePhysics;
    public bool isGrabbed;
    public XRGrabInteractable XRGrabInteractable;
    public GameObject magicBullet;
    public Transform spawnPoint;

    // Awake runs once at the beginning play (only once)
    private void Awake()
    {
        Debug.Log("Awake");

        inputActions = new XRIDefaultInputActions();
        inputActions.Enable();

        //On Grab
        XRGrabInteractable.selectEntered.AddListener(OnGrab);
        //On Release
        XRGrabInteractable.selectExited.AddListener(OnRelease);
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            // shoot here
            Debug.Log("Shoot magic");

            GameObject tempBullet = Instantiate(magicBullet, spawnPoint.position, spawnPoint.rotation);
            if (usePhysics)
            {
                tempBullet.GetComponent<Rigidbody>().useGravity = true;
            }
            else
            {
                tempBullet.GetComponent<Rigidbody>().useGravity = false;
            }
        }
    }
    public void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("On grabbed");
        isGrabbed = true;
        inputActions.XRILeftHandInteraction.Activate.started += OnShoot;
    }

    public void OnRelease(SelectExitEventArgs args)
    {
        Debug.Log("On grabbed");
        isGrabbed = false;
        inputActions.XRILeftHandInteraction.Activate.started -= OnShoot;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
