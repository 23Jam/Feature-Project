using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    private PlayerInput playerInputAction;

    public Transform sheildSpawnPoint;
    public GameObject sheildPrefab;

    private void Awake()
    {
        playerInputAction = new PlayerInput();
        playerInputAction.Enable();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Vector2 moveVec = playerInputAction.Jump.ReadValue<Vector2>();
        //rigidBody.AddForce(new Vector3(moveVec.x, 0, moveVec.y) * 5f, ForceMode.Force);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if(context.performed)
        {
            rigidBody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            Debug.Log("The jump button is pressed!" + context.phase);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        //if (context.performed)
        {
            Vector2 moveVec = context.ReadValue<Vector2>();
            rigidBody.AddForce(new Vector3(moveVec.x, 0, moveVec.y) * 5, ForceMode.Force);
        }
    }

    
    public void Sheild(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        //if (context.performed)
        {
            Debug.Log("The Sheild button is pressed.");
            var sheild = Instantiate(sheildPrefab, sheildSpawnPoint.position, sheildSpawnPoint.rotation);
            sheild.GetComponent<Rigidbody>().velocity = sheildSpawnPoint.up;
        }
    }
    
}
