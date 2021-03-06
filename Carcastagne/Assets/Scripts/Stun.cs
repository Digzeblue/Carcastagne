using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun : MonoBehaviour
{
    private float stunTime;
    public float dureeStun;
    private bool isStunned = false;

    public Animator animator;
    private Mouvement mouvement;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        mouvement = GetComponent<Mouvement>();
        rb = GetComponent<Rigidbody2D>();
        stunTime = dureeStun;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStunned)
        {
            if(stunTime <= 0)
            {
                mouvement.OnEnable();
                stunTime = dureeStun;
                isStunned = false;
                animator.SetBool("TombeDuSol", false);
            } else
            {
                rb.velocity = Vector3.zero;
                stunTime -= Time.deltaTime;
            }
        }
    }

    public void Stunned()
    {
        mouvement.OnDisable();
        isStunned = true;
        animator.SetBool("TombeDuSol", true);
    }
}
