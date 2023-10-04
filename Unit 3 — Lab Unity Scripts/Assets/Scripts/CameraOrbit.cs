using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
   public float lookSensitivity;
   public float minXLook;
   public float maxXLook;
   public Transform camAnchor;

   public bool invertXRotation;

   private float curXRot;

   void LateUpdate ()
   {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        transform.eulerAngles += vector3.up * x * lookSensitivity;
   }
}
