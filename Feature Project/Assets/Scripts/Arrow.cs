using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    /*
    public float health = 1;

    void Awake()
    {
        Destroy(gameObject, health - 1);
    }

    
    void OnCollusionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
    }
    */

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }

}
