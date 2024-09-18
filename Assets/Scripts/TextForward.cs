using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextForward : MonoBehaviour
{
    public Camera cameraToLookAt;
    void Start()
    {
        cameraToLookAt = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + cameraToLookAt.transform.rotation * Vector3.forward,
        cameraToLookAt.transform.rotation * Vector3.up);
    }
}
