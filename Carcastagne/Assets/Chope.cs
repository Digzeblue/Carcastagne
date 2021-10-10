using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chope : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;

    public float rangeAttaque = 0.5f;

    public LayerMask cochonCalque;
    
    public void FaireUneChope()
    {
        //Joue l'animation de chope
        animator.SetTrigger("Chope");

        //Detectes le cochon dans la range
        Collider2D[] EnnemiAttrapé = Physics2D.OverlapCircleAll(attackPoint.position, rangeAttaque, cochonCalque);


        

    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, rangeAttaque);
    }
}
