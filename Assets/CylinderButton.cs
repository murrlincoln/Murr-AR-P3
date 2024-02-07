using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ToggleTextInteraction : MonoBehaviour
{
    private GameObject infoText;
    private GameObject reviewText;
    private bool isInfoVisible = true;

    void Start()
    {
        // Find the text objects by their names
        infoText = GameObject.Find("Info");
        reviewText = GameObject.Find("Review");

        // Initially, set the review text to be invisible if the info text is meant to be visible first
        if (infoText != null && reviewText != null)
        {
            reviewText.SetActive(!isInfoVisible);
        }
    }

    void Update()
    {
        // Check for a mouse click or a screen tap
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray;
            // Determine whether the input is a touch or a click and set the ray accordingly
            if (Input.touchCount > 0)
            {
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            }
            else
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            }

            RaycastHit hit;
            // Perform the raycast
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the ray hits an object tagged as "Interactable" (your button)
                if (hit.collider.CompareTag("Button"))
                {
                    // Toggle between the Info and Review texts
                    ToggleText();
                }
            }
        }
    }

    void ToggleText()
    {
        if (infoText == null || reviewText == null) return;

        isInfoVisible = !isInfoVisible; // Toggle the state
        infoText.SetActive(isInfoVisible);
        reviewText.SetActive(!isInfoVisible);
    }
}


