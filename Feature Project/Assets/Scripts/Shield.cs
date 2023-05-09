using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    public GameObject shield;

    private bool activeShield;

    void Start()
    {
        activeShield = false;
        shield.SetActive(false);
    }


    public void Sheild(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if (context.performed)
        {
            Debug.Log("The button is pressed.");
            //Sheild.SetActive(true);
            shield.SetActive(true);
            activeShield = true;
        }
        else
        {
            shield.SetActive(false);
            activeShield = false;
        }
        
    }

    public bool ActiveShield
    {
        get
        {
            return activeShield;
        }
        set
        {
            activeShield = value;
        }
    }
}
