using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedirectedWalking : MonoBehaviour
{
    // Start is called before the first frame update
    private OVRCameraRig OVRCameraRig;

    private Rigidbody Rigidbody;

    private void Start()
    {
        OVRCameraRig = GameObject.Find("OVRCameraRig").GetComponent<OVRCameraRig>();
        Rigidbody = GameObject.Find("Ball").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        Rigidbody.transform.position = OVRCameraRig.centerEyeAnchor.position;
    }
}