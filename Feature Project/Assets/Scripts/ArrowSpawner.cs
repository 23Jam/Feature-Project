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

    //[SerializeField]
    private float arrowInterval = 15.0f;

    public float arrowPosMin;

    public float arrowPosMax;

    public float arrowSpeed;

    public GameObject arrow;
    public Transform arrowPos;

    private float timer;

    private void Awake()
    {
        ArrowRigidBody = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        //StartCoroutine(spawnArrow(arrowInterval, arrowPrefab));
    }
    
    private IEnumerator spawnArrow(float interval, GameObject player)
    {
        yield return new WaitForSeconds(interval);
        GameObject newArrow = Instantiate(player, new Vector3(Random.Range(arrowPosMin, arrowPosMax), Random.Range(arrowPosMin, arrowPosMax)), Quaternion.identity);
        StartCoroutine(spawnArrow(interval, player));
    }
    

    void Update()
    {
        //enemy.SetDestination(PlayerController.position);
        //Arrow();
        /*
        timer += Time.deltaTime;
        
        if(timer > 2)
        {
            timer = 0;
            shoot();
        }
        */
    }

    void shoot()
    {
        Instantiate(arrow, arrowPos.position, arrowPos.rotation);
    }

    public void Arrow()
    {
        //arrowTime -= Time.deltaTime;
        //if (arrowTime > 0) return;

        //arrowTime = timer;
        
        var arrow = Instantiate(arrowPrefab, arrowSpawnPoints[0].position, arrowSpawnPoints[0].rotation);
        arrow.GetComponent<Rigidbody>().velocity = arrowSpawnPoints[0].forward * arrowSpeed;
        //arrow.AddForce(arrow.transform.forward * arrowSpeed);
    }
}
