using UnityEngine;

public class MacMovementRedirector : MonoBehaviour
{

    [SerializeField] private Transform mainCamera;
    [SerializeField] private Transform movementProxy;

    private Vector3 previousCameraWorldPos;

    private void Start()
    {
        if ((mainCamera == null) || (movementProxy == null))
        {
            Debug.LogError("Assign mainCamera and movementProxy!");
        }

        previousCameraWorldPos = mainCamera.position;
    }

    private void LateUpdate()
    {
        Vector3 currentCameraWorldPos = mainCamera.position;
        Vector3 delta = currentCameraWorldPos - previousCameraWorldPos;

        // Move the entire proxy by the camera movement
        movementProxy.position += new Vector3(delta.x, 0f, delta.z);

        // Snap the camera back to its original local position
        mainCamera.localPosition = new Vector3(0f, mainCamera.localPosition.y, 0f);

        previousCameraWorldPos = mainCamera.position;
    }
}
