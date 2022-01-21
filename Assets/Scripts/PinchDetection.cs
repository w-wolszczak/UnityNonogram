using System.Collections;
using UnityEngine;

public class PinchDetection : MonoBehaviour
{
    
    [SerializeField]
    private float cameraSpeed = 4f;

    private TouchControls controls;
    private Coroutine zoomCoroutine;
    private Transform cameraTransform;
    
    private void Awake()
    {
        controls = new TouchControls();
        cameraTransform = Camera.main.transform;   
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Start()
    {
        controls.Touch.SecondaryTouchContact.started += _ => PinchStart();
        controls.Touch.SecondaryTouchContact.canceled += _ => PinchEnd();
    }

    private void PinchStart()
    {
        zoomCoroutine = StartCoroutine(ZoomDetection());
    }

    private void PinchEnd()
    {
        StopCoroutine(zoomCoroutine);
    }
    IEnumerator ZoomDetection()
    {
        float previousDistance = 0f, distance = 0f;
        while (true)
        {
            distance = Vector2.Distance(controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(), 
                                        controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
            //Detection
            //zoom in
            if (distance > previousDistance)
            {
                Vector3 targetPosition = cameraTransform.position;
                targetPosition.z += 1;
                cameraTransform.position = Vector3.Slerp(cameraTransform.position, targetPosition, Time.deltaTime * cameraSpeed);
            }
            //zoom out
            else if (distance < previousDistance)
            {   
                Vector3 targetPosition = cameraTransform.position;
                targetPosition.z -= 1;
                cameraTransform.position = Vector3.Slerp(cameraTransform.position, targetPosition, Time.deltaTime * cameraSpeed);
            }
                //keep track of previous distance for next loop
                previousDistance = distance;
            yield return null;
                    }
    }
}
