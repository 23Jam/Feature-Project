using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    public GameObject shield;

    private bool activeShield;

    public float health;

    void Start()
    {
        health = 10f;
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Arrow")
        {
            //TakeDamage(1f);
            Destroy(gameObject, health - 1);
        }
    }
}
