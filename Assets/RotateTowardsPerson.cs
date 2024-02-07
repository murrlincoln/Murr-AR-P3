using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPerson : MonoBehaviour
{

    private Transform textObject; // To hold the 3D Text object

    void Start()
    {
        // Find the 3D Text object by tag
        GameObject foundObject = GameObject.FindGameObjectWithTag("3DText");
        if (foundObject != null)
        {
            textObject = foundObject.transform;
        }
    }

    void Update()
    {
        // Rotate only the 3D Text object to face the camera
        if (textObject != null)
        {
            textObject.LookAt(Camera.main.transform);
            textObject.Rotate(0, 180, 0); // Adjust for correct facing
        }
    }
}

