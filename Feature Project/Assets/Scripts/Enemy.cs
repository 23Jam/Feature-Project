using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float timer = 5;
    private float arrowTime;

    public GameObject enemyArrow;
    public Transform spawnPoint;
    public float enemySpeed;

    void Update()
    {
        //enemy.SetDestination(player.position);
    }

    void Shoot()
    {
        arrowTime -= Time.deltaTime;
        if (arrowTime > 0) return;
        arrowTime = timer;

        //GameObject arrowObj = Instantiate(enemyArrow, spawnPoint.eulerAngles position, spawnPoint.transform.rotation);
        //Rigidbody arrowRig = arrowObj.GetComponent<Rigidbody>();
        //arrowRig.AddForce(arrowRig.transform.forward * enemySpeed);
    }
    /*
    private Rigidbody enemyRigidBody;

    public Transform arrowSpawnPoint;
    public GameObject arrowPrefab;

    public void Arrow()
    {
        //Debug.Log(context);
        //{
            //var arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, arrowSpawnPoint.rotation);
            //arrow.GetComponent<Rigidbody>().velocity = arrowSpawnPoint.forward;
        //}
    }
    */
}
