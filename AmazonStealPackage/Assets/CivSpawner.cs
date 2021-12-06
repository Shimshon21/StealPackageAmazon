using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivSpawner : MonoBehaviour
{
    public GameObject civPrefab;
    public Transform spawnPoint;
    public float timeSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCiv",0, 10f);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnCiv()
    {
        Instantiate(civPrefab, spawnPoint.position, Quaternion.identity);
    }
}
