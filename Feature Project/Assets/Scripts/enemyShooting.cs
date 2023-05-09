using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    //public GameObject arrow;
    //public Transform arrowPos;

    //private float timer;

    private GameObject player;
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            shoot();
        }
        */
    }

    /*
    void shoot()
    {
        Instantiate(arrow, arrowPos.position, Quaternion.identity);
    }
    */
}
