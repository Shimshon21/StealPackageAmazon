using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighManager : MonoBehaviour
{
    [SerializeField] GameObject lights;
    [SerializeField] GameObject doorTrap;
    [SerializeField] int trapTime = 2;
    [SerializeField] int turnOffLights = 5;
    int turnLightsTime = 0;

    float time = 0;

    private void Awake()
    {
        turnLightsTime = UnityEngine.Random.Range(0, 60);
    }


    private void Update()
    {
        if(lights.activeSelf && time > turnLightsTime + trapTime + turnOffLights)
        {
            doorTrap.SetActive(false);
            lights.SetActive(false);
            time = 0;
        }

        else if (lights.activeSelf && time > turnLightsTime + trapTime)
        {
            doorTrap.SetActive(true);
        }

        else if(time > turnLightsTime)
        {
            lights.SetActive(true);
        }

        time += Time.deltaTime;
    }

}
