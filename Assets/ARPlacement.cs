using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EmhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

[RequireComponent(typeof(ARRaycastManager),typeof(ARPlaneManager))]
public class ARPlacement : MonoBehaviour
{

    public  GameObject arObjectToSpawn;

    private ARRaycastManager aRRaycastManager;
    private ARPlaneManager aRPlaneManager;
   public static bool spawned;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    private void OnEnable()
    {
        EmhancedTouch.TouchSimulation.Enable();
        EmhancedTouch.EnhancedTouchSupport.Enable();
        EmhancedTouch.Touch.onFingerDown += FingerDown;
    }

    private void OnDisable()
    {
        EmhancedTouch.TouchSimulation.Disable();
        EmhancedTouch.EnhancedTouchSupport.Disable();
        EmhancedTouch.Touch.onFingerDown -= FingerDown;
    }
    private void FingerDown(EmhancedTouch.Finger finger)
    {
        if(spawned == true)
        {
            return;
        }
        if (aRRaycastManager.Raycast(finger.currentTouch.screenPosition, hits, TrackableType.PlaneWithinPolygon) && spawned == false) 
        {
            Pose pose = hits[0].pose;
            GameObject obj = Instantiate(arObjectToSpawn, pose.position, pose.rotation);
            spawned = true;
        }
    }
    public void OnDespawn()
    {
        Destroy(GameObject.FindWithTag("Pet"));
        spawned = false;
    }
}


