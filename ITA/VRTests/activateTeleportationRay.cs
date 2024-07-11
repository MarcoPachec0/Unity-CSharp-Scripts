using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    public XRDirectInteractor leftInteractor;
    public XRDirectInteractor rightInteractor;

    // Update is called once per frame
    void Update()
    {
        bool isLeftHandHoldingObject = leftInteractor.hasSelection;
        bool isRightHandHoldingObject = rightInteractor.hasSelection;

        // Only activate the teleportation rays if the hands are not holding objects
        leftTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f && !isLeftHandHoldingObject);
        rightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f && !isRightHandHoldingObject);
    }
}
