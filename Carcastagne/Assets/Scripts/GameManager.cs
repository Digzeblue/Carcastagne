using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Camera
    public Transform cam;
    public Transform posCam0;
    public Transform posCam1;
    public Transform posCam2;
    public float speedCam;

    //Respawn Joueur
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (cam.position.x > posCam1.position.x)
        {
            cam.Translate(Vector2.left * speedCam * Time.deltaTime);
        }

        if (cam.position.x < posCam2.position.x)
        {
            cam.Translate(Vector2.right * speedCam * Time.deltaTime);
        }

    }





}
