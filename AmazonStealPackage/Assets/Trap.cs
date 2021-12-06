using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] AudioClip oMy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if(player && player.HeldBox)
        {
            GetComponent<AudioSource>().PlayOneShot(oMy);
            player.PlayerCaught();
        }

    }
}
