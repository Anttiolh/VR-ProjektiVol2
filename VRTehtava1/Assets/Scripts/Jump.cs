using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    public InputActionReference jumpButton;
    public float jumpForce = 50f;
    public Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        jumpButton.action.performed += OnJump;
    }

    private void OnJump(InputAction.CallbackContext context)
    {

        rb.AddForce(Vector3.up * jumpForce);
    }
}
