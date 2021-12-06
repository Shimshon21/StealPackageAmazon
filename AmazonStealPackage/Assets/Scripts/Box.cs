using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    bool isCarried = false;
    Carry carry;
    Transform carryTran;
    Trash trash;
    // Start is called before the first frame update
    void Start()
    {
        carry = FindObjectOfType<Carry>();
        carryTran = carry.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCarried)
        {
            transform.position = carryTran.position;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if (player == null) return;

        if (player.HeldBox != null) return;

        player.HeldBox = this;

        isCarried = true;
        GameObject changeMe = this.gameObject.transform.GetChild(1).gameObject;
        changeMe.GetComponent<SpriteRenderer>().enabled = false;
        player.NowCarry(this);
        gameObject.tag = "box";
        Debug.Log("called now carry");
    }
}

