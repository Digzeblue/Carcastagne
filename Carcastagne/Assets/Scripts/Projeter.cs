using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projeter : MonoBehaviour
{
    public float liftDuree;
    public float throwForce;
    public Transform holdPoint;

    private float liftTime;

    public bool isGrabed = false;
    public bool isThrowed = false;
    private Rigidbody2D pigRB;
    private Mouvement pigControl;
    public Mouvement carcasControl;

    // Start is called before the first frame update
    void Start()
    {
        pigRB = GetComponent<Rigidbody2D>();
        pigControl = GetComponent<Mouvement>();

        liftTime = liftDuree;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" && isThrowed == true)
        {
            //Atteint le sol
            pigControl.OnEnable();
        }
    }
    public void Jeter()
    {
        pigControl.OnDisable();
        isGrabed = true;

        Souleve();

        StartCoroutine("waiter");   //Attendre

        isGrabed = false;
        isThrowed = true;
        Projete();
    }

    void Souleve()
    {
        pigControl.actualDirection = carcasControl.actualDirection;
        pigRB.transform.position = holdPoint.position;
        pigRB.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    void Projete()
    {
        pigRB.constraints = RigidbodyConstraints2D.FreezeRotation;
        pigRB.velocity = new Vector2(1, 1) * throwForce;
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(liftDuree);
    }
}
