using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    private Rigidbody ArrowRigidBody;

    public Transform arrowSpawnPoint;
    //public GameObject arrowPrefab;

    public Transform[] arrowSpawnPoints;
    public GameObject arrowPrefabs;

    [SerializeField]
    private GameObject arrowPrefab;

    [SerializeField]
    private float arrowInterval = 15.0f;

    private void Awake()
    {
        ArrowRigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        StartCoroutine(arrowSpawner(arrowInterval, arrowPrefab));
    }
}
