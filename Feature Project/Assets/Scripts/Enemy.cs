using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRigidBody;

    public Transform arrowSpawnPoint;
    public GameObject arrowPrefab;

    public void Arrow()
    {
        //Debug.Log(context);
        //{
            var arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, arrowSpawnPoint.rotation);
            arrow.GetComponent<Rigidbody>().velocity = arrowSpawnPoint.forward;
        //}
    }
}
