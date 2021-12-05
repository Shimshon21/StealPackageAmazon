using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] GameObject box;
    [SerializeField] Transform boxCreation;
    [SerializeField] float oddsForBox = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BoxDropped()
    {
        Debug.Log("dropped box active");
        float ranNum = Random.Range(0f, 1f);
        Debug.Log("ranNum= " + ranNum);
        if (ranNum > 0.4f) {
            Debug.Log("i throw box");
            Instantiate(box, boxCreation.position, Quaternion.identity);
            
                }
    }
}
