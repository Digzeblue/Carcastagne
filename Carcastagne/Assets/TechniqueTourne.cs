using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechniqueTourne : MonoBehaviour
{
    int newscale;
    
    // Start is called before the first frame update


    void Start()
    {
        Vector3 local = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Mouvement>().isLookingLeft)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
