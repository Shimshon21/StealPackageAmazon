using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    [SerializeField] float speed;
    private PlayerInputActions inputActions;


    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        inputActions = new PlayerInputActions();
        inputActions.Player.Enable();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector2 inputVector = inputActions.Player.Movment.ReadValue<Vector2>();

        rigidbody2D.velocity = inputVector * speed;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "SupBox")
        {
            Debug.Log("Score added");
            Destroy(collision.gameObject);
        }
    }

}
