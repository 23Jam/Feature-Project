using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    private Rigidbody ArrowRigidBody;

    public Transform arrowSpawnPoint;
    public GameObject arrowPrefab;

    private void Awake()
    {
        ArrowRigidBody = GetComponent<Rigidbody>();
    }
}
