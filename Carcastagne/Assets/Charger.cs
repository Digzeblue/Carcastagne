using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour
{
    private int direction;
    private Mouvement mouvement;

    private Rigidbody2D rb;
    public float dashSpeed;
    public float startDashTime;
    private float dashTime;
    public float cooldown;
    private float nextDash;

    private bool isCharging;
    // Start is called before the first frame update
    void Start()
    {
        mouvement = GetComponent<Mouvement>();
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(direction != 0)
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            } else
            {
                dashTime -= Time.deltaTime;
                if(direction == 1)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
                if (direction == -1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
            }
        }
    }

    public void Charge()
    {
        if (direction == 0 && Time.time > nextDash)
        {
            direction = mouvement.actualDirection;
            nextDash = Time.time + cooldown;
            //Animation charge
        }   
    }
}
