using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    private PlayerInput playerInputAction;

    private void Awake()
    {
        playerInputAction = new PlayerInput();
        playerInputAction.Enable();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Vector2 moveVec = playerInputAction.PlayerInput.Jump.ReadValue<Vector2>();
        //rigidBody.AddForce(new Vector3(moveVec.x, 0, moveVec.y) * 5f, ForceMode.Force);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if (context.performed)
        {
            rigidBody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            Debug.Log("The jump button is pressed!" + context.phase);
        }
    }
}
