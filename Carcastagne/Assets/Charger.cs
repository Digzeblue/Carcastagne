using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour
{
    private int direction;
    private Mouvement mouvement;

    public Animator animator;
    private Rigidbody2D rb;
    public float dashSpeed;
    public float startDashTime;
    private float dashTime;
    public float cooldown;
    private float nextDash;

    private bool isCharging = false;
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
                isCharging = false;
                //Fin Animation charge
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Carcasse" && isCharging)
        {
            collision.gameObject.GetComponent<Stun>().Stunned();
        }
    }

    public void Charge()
    {
        if (direction == 0 && Time.time > nextDash)
        {
            isCharging = true;
            direction = mouvement.actualDirection;
            nextDash = Time.time + cooldown;
            //Animation charge
            animator.SetTrigger("EnTrainDeCharger");
        }   
    }
}
