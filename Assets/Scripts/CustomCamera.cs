using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCamera : MonoBehaviour
{
    public Transform marble;
    public Vector3 cameraOffset = new Vector3(0f, 1.5f, -5f);
    private Vector3 followSpeed = Vector3.zero;
    public float smoothTime = 0.25f;

    void LateUpdate() {
        // For a smoot follow the Vector3.SmoothDamp function is relevant
        // or use Vector3.Lerp to smooth out the position between two Vector3
        // with higher smoothTime the camera takes longer to start following
        // follow up speeds gets calculated while moving so there is nothing to be set.
        Vector3 targetPosition = marble.position + cameraOffset;
        this.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref followSpeed, smoothTime);
    }
}
