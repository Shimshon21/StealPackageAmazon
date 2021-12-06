using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] GameObject box;
    [SerializeField] Transform boxCreation;
    [SerializeField] float oddsForBox;
    [SerializeField] AudioClip crashSound;
    [SerializeField] AudioClip beepSound;
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
        if (ranNum < oddsForBox) {

            Instantiate(box, boxCreation.position, Quaternion.identity);
        }
    }

    public void Honk()
    {
        GetComponent<AudioSource>().PlayOneShot(beepSound);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();

        if (player)
        {
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            player.PlayerCaught();
        }
    }

    
}
