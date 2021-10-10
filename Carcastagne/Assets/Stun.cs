using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun : MonoBehaviour
{
    private float stunTime;
    public float dureeStun;
    private bool isStunned = false;

    private Mouvement mouvement;

    // Start is called before the first frame update
    void Start()
    {
        mouvement = GetComponent<Mouvement>();
        stunTime = dureeStun;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStunned)
        {
            if(dureeStun <= 0)
            {
                mouvement.OnEnable();
                stunTime = dureeStun;
                isStunned = false;
                Debug.Log("Fin du stun");
                //fin animation stun
            } else
            {
                stunTime -= Time.deltaTime;
            }
        }
    }

    public void Stunned(Rigidbody2D rb)
    {
        mouvement.OnDisable();
        //rb.constraints.

        isStunned = true;
        Debug.Log("Touché !");
        //Début Animation Stun
    }
}
