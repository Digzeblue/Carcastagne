using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public Transform cam;


    float speedCam = 50f;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cochon")
        {
            cam.Translate(Vector2.left * speedCam);
        }
    }
}
