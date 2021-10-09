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

    private void Awake()
    {
        control = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();

        control.Gameplay.Jump.performed += ctx => Jump();
        control.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        control.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    }

    void Jump()
    {
        rb.velocity = new Vector2(0,1) * hauteurSaut;
    }

    private void Update()
    {
        Vector2 m = new Vector2(move.x, 0)*vitesse*Time.deltaTime;
        transform.Translate(m, Space.World);
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
