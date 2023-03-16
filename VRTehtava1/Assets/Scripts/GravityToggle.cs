using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GravityToggle : MonoBehaviour
{
    public InputActionReference toggleGravity;
    public Rigidbody rb;
    bool isActive = true;
    
    private void Awake()
    {
        toggleGravity.action.started += Toggle;
    }
    /*
    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }
    */
    private void Toggle(InputAction.CallbackContext context)
    {
        isActive = !isActive;
        rb.useGravity = isActive;
    }
}
