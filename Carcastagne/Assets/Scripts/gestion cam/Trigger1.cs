using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public Transform cam;
    public Transform queen;

    public Transform targetLocationCam;
    public Transform targetLocationPig;
    public Transform targetLocationQueen;
   

    float speedCam = 50f;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.gameObject.tag == "Cochon")
        {
            Player.gameObject.transform.position = targetLocationPig.position;
            cam.gameObject.transform.position = targetLocationCam.position;
            queen.gameObject.transform.position = targetLocationQueen.position;
        }
    }


}
