using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlsceObjectOnPlane : MonoBehaviour
{
    private GameObject spawnNew;

    private ARRaycastManager arRaycast;
    private ARPlaneManager arPlane;

    [SerializeField]
    public GameObject[] array;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
