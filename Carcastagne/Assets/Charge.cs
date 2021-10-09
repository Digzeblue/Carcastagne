using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    private Rigidbody2D rb;
    private Mouvement mouvement;

    public float dashSpeed;
    public float startDashTime;
    private float dashTime;
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mouvement = GetComponent<Mouvement>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(dashTime <= 0)
        {
            direction = 0;
            dashTime = startDashTime;
        } else
        {
            dashTime -= Time.deltaTime;

            rb.velocity = new Vector2(direction, 0) * dashSpeed;
        }
    }

    public void Dash()
    {
        if(direction == 0)
        {
            if (mouvement.move.x > 0)
            {
                direction = 1;
            }
            if (mouvement.move.x < 0)
            {
                direction = -1;
            }
        }
    }
}
