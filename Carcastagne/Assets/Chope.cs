using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chope : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;

    public float rangeAttaque = 0.5f;

    public LayerMask cochonCalque;

    public float cooldown;
    private float nextGrab;

    public void FaireUneChope()
    {
        //Joue l'animation de chope
        animator.SetTrigger("Chope");

        //Detectes le cochon dans la range
        Collider2D[] EnnemiAttrapé = Physics2D.OverlapCircleAll(attackPoint.position, rangeAttaque, cochonCalque);
        if(EnnemiAttrapé != null && Time.time > nextGrab)
        {
            nextGrab = Time.time + cooldown;
            foreach (Collider2D pig in EnnemiAttrapé)
            {
                //Animation jeter
                pig.GetComponent<Projeter>().Jeter();
            }
        }else
        {
            animator.SetBool("Chope", false);
        }

        

    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, rangeAttaque);
    }
}
