using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechniqueTourne : MonoBehaviour
{
    int newscale;
    int direction;
    
    // Start is called before the first frame update


    void Start()
    {
        Vector3 local = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Cochon")
        {
            direction = -GetComponent<Mouvement>().actualDirection;
            if (GetComponent<Mouvement>().isLookingLeft)
            {
                transform.localScale = new Vector3(direction, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(direction, 1, 1);
            }
        }
        if (gameObject.tag == "Carcasse")
        {
            direction = GetComponent<Mouvement>().actualDirection;
            if (GetComponent<Mouvement>().isLookingLeft)
            {
                transform.localScale = new Vector3(0.5f*direction, 0.5f, 0.5f);
            }
            else
            {
                transform.localScale = new Vector3(0.5f*direction, 0.5f, 0.5f);
            }
        }
        
    }
}
