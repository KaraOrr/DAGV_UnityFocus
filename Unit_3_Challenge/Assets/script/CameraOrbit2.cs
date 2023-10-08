using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit2 : MonoBehaviour
{
   public float lookSensitivity;
   public float minXLook;
   public float maxXLook;
   public Transform camAnchor;
   public float smoothSpeed;
   public Transform CamTarget;
   public bool invertXRotation;
   public Vector3 offset;

   private float curXRot;

   void Start ()
   {
        Cursor.lockState = CursorLockMode.Locked;
   }

   void LateUpdate ()
   {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        transform.eulerAngles += Vector3.up * x * lookSensitivity;

        if(invertXRotation)
            curXRot += y * lookSensitivity;
        else
            curXRot -= y * lookSensitivity;

        curXRot = Mathf.Clamp(curXRot, minXLook, maxXLook);

        Vector3 clampedAngle = camAnchor.eulerAngles;
        clampedAngle.x = curXRot;

        camAnchor.eulerAngles = clampedAngle;
/*
        Vector3 desiredPosition = CamTarget.position + offset; //desired postition is the position where we want the camera to be
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed * Time.deltaTime); //smoothed position is used to create a slow or fast effect towards the player
        transform.position = smoothedPosition; */
   }
}