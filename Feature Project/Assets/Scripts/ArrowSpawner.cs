using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    private Rigidbody ArrowRigidBody;

    //public Transform arrowSpawnPoint;
    //public GameObject arrowPrefab;

    public Transform[] arrowSpawnPoints;
    public GameObject arrowPrefabs;
    [SerializeField]
    private GameObject arrowPrefab;

    [SerializeField]
    private float arrowInterval = 15.0f;

    public float arrowPosMin;

    public float arrowPosMax;

    /*
    private void Awake()
    {
        ArrowRigidBody = GetComponent<Rigidbody>();
    }
    */
    void Start()
    {
        StartCoroutine(spawnArrow(arrowInterval, arrowPrefab));
    }

    private IEnumerator spawnArrow(float interval, GameObject player)
    {
        yield return new WaitForSeconds(interval);
        GameObject newArrow = Instantiate(player, new Vector3(Random.Range(arrowPosMin, arrowPosMax), Random.Range(arrowPosMin, arrowPosMax)), Quaternion.identity);
        StartCoroutine(spawnArrow(interval, player));
    }
}
