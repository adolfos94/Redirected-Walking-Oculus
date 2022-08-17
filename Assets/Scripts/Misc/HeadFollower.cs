using UnityEngine;
using Redirection;

public class HeadFollower : MonoBehaviour
{
    private OVRCameraRig OVRCameraRig;

    // Use this for initialization
    private void Start()
    {
        OVRCameraRig = GameObject.Find("OVRCameraRig").GetComponent<OVRCameraRig>();
    }

    // Update is called once per frame
    private void Update()
    {
        var currPos = Utilities.FlattenedPos3D(OVRCameraRig.centerEyeAnchor.position);
        var currDir = Utilities.FlattenedDir3D(OVRCameraRig.centerEyeAnchor.forward);

        transform.position = currPos;
        transform.rotation = Quaternion.LookRotation(currDir, Vector3.up);
    }
}