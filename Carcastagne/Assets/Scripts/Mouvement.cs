using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvement : MonoBehaviour
{
    public float hauteurSaut = 5;
    public float vitesse = 10;
    PlayerControls control;
    Rigidbody2D rb;
    Vector2 move;

    private PlayerInput playerInput;
    public int playerIndex = 0;

    private void Awake()
    {
        control = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        var index = playerInput.playerIndex;
    }

    void Jump(InputAction.CallbackContext ctx)
    {
            rb.velocity = new Vector2(0, 1) * hauteurSaut;
    }

    void Move(InputAction.CallbackContext ctx)
    {
        move = ctx.ReadValue<Vector2>() * Time.deltaTime * vitesse;
    }

    private void Update()
    {
        Vector2 m = new Vector2(move.x, 0);
        transform.Translate(m);
    }


    private void OnEnable()
    {
        control.Gameplay.Enable();
    }

    private void OnDisable()
    {
        control.Gameplay.Disable();
    }
}
