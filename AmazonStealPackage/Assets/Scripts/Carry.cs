using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : MonoBehaviour
{
    //bool carry = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NowCarry()
    {
        Debug.Log("I'm now carry");
        gameObject.tag = "carry";
        Debug.Log("now carry no problem");
    }
    public void NowEmpty()
    {
        gameObject.tag = "empty";
    }
}
