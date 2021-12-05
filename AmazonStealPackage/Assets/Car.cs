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
        float ranNum = Random.Range(0f, 1f);
        if (ranNum > 0.7f) {
            Debug.Log("i throw box");
            Instantiate(box, boxCreation.position, Quaternion.identity);
            
                }
    }

    public void DestoyCar()
    {
        Destroy(gameObject);
    }    
}
