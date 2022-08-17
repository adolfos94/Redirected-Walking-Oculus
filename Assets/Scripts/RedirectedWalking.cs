using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedirectedWalking : MonoBehaviour
{
    // Start is called before the first frame update
    private OVRCameraRig m_OVRCameraRig;

    private GameObject m_TrackedSpace;

    private void Start()
    {
        m_OVRCameraRig = GameObject.Find("OVRCameraRig").GetComponent<OVRCameraRig>();
        m_TrackedSpace = GameObject.Find("TrackedSpace");

        Vector3 dimensions = OVRManager.boundary.GetDimensions(OVRBoundary.BoundaryType.PlayArea);
    }

    // Update is called once per frame
    private void Update()
    {
#if UNITY_EDITOR
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);

        m_OVRCameraRig.centerEyeAnchor.Translate(movementDirection * Time.deltaTime);
#endif
    }
}