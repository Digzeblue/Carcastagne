using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvement : MonoBehaviour
{
    public float hauteurSaut = 5;
    public float vitesse = 10;
    Rigidbody2D rb;
    public Vector2 move;

    private PlayerInput playerInput;
    public int playerIndex = 0;

    public Animator animator;
    public bool isGrounded = false;
    public bool isMoving = false;
    public bool isLookingLeft = false;
    private bool changeDirection = false;
    public int actualDirection = 1;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        var index = playerInput.playerIndex;

    }

    void Jump(InputAction.CallbackContext ctx)
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(0, 1) * hauteurSaut;
        }
    }

    void Move(InputAction.CallbackContext ctx)
    {
        move = ctx.ReadValue<Vector2>() * Time.deltaTime * vitesse;
    }

    private void FixedUpdate()
    {
        Vector2 m = new Vector2(move.x, 0);
        transform.Translate(m);
    }

    private void Update()
    {
        if(move.x * actualDirection < 0)
        {
            changeDirection = true;
            actualDirection *= -1;
        } else
        {
            changeDirection = false;
        }
        if (animator != null)
        {
            isMoving = !(move == new Vector2(0, 0));
            animator.SetBool("MarcheActuellement", isMoving);
            isLookingLeft = (move.x < 0);
            animator.SetBool("RegardeVersVictoire", isLookingLeft);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }

    }


    public void OnEnable()
    {
        playerInput.enabled(true);
    }

    public void OnDisable()
    {

    }
}
