using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject car;
    [SerializeField] float timeToSpawn=10f;
    float timetoNextSpawn = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CarCreator", 0, timeToSpawn);
    }
    private void CarCreator()
    {
        Instantiate(car, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
