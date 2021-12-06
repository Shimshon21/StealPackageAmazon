using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    Box heldBox;
    [SerializeField] float speed;
    [SerializeField] GameObject gameOver;
    private PlayerInputActions inputActions;

    public Box HeldBox { get; set; }


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
    public void NowCarry(Box box)
    {
        heldBox = box;
        Debug.Log("I'm now carry");
        gameObject.tag = "carry";
        Debug.Log("now carry no problem");
    }
    public void NowEmpty()
    {
        gameObject.tag = "empty";
    }
    public void destroyBox()
    {
        FindObjectOfType<ScoreCounter>().AddScore();
        NowEmpty();
        Destroy(heldBox.gameObject);
    }

    public void PlayerCaught()
    {
        Time.timeScale = 0f;
        Instantiate(gameOver, Vector2.zero, Quaternion.identity);
    }


}
