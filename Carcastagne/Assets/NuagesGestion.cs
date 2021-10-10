using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuagesGestion : MonoBehaviour
{
    /*
    [Header("Clouds RectTransform")]
    public Transform Cloud1;
    public Transform Cloud11;
    public Transform Cloud2;
    public Transform Cloud22;
    public Transform Cloud3;
    public Transform Cloud33;

    [Header("Clouds Stock Position")]
    public Vector3 StockC1;
    public Vector3 StockC11;
    public Vector3 StockC2;
    public Vector3 StockC22;
    public Vector3 StockC3;
    public Vector3 StockC33;

    [Header("Clouds ResetPosition")]
    public Vector3 ResetC1;
    public Vector3 ResetC2;
    public Vector3 ResetC3;

    [Header("Clouds Speed")]
    public float SpeedC1;
    public float SpeedC2;
    public float SpeedC3;

    // Start is called before the first frame update
    void Start()
    {
        StockC1 = Cloud1.localPosition;
        StockC11 = Cloud11.localPosition;
        StockC2 = Cloud2.localPosition;
        StockC22 = Cloud22.localPosition;
        StockC3 = Cloud3.localPosition;
        StockC33 = Cloud33.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        CloudMovement();
        ResetClouds();
    }

    //Fonction qui gère le déplacement des nuages
    public void CloudMovement()
    {
        //Mouvement Nuage 1
        StockC1.x += SpeedC1 * Time.deltaTime;
        Cloud1.localPosition = StockC1;

        //Mouvement Nuage 1-2
        StockC11.x += SpeedC1 * Time.deltaTime;
        Cloud11.localPosition = StockC11;

        //Mouvement Nuage 2
        StockC2.x += SpeedC2 * Time.deltaTime;
        Cloud2.localPosition = StockC2;

        //Mouvement Nuage 2-2
        StockC22.x += SpeedC2 * Time.deltaTime;
        Cloud22.localPosition = StockC22;

        //Mouvement Nuage 3
        StockC3.x += SpeedC3 * Time.deltaTime;
        Cloud3.localPosition = StockC3;

        //Mouvement Nuage 3-2
        StockC33.x += SpeedC3 * Time.deltaTime;
        Cloud33.localPosition = StockC33;
    }

    public void ResetClouds()
    {
        //Reset Nuage 1
        if (Cloud1.localPosition.x >= 2000)
        {
            StockC1 = ResetC1;
            Cloud1.localPosition = StockC1;
        }

        //Reset Nuage 1-2
        if (Cloud11.localPosition.x >= 2000)
        {
            StockC11 = ResetC1;
            Cloud11.localPosition = StockC1;
        }

        //Reset Nuage 2
        if (Cloud2.localPosition.x >= 1250)
        {
            StockC2 = ResetC2;
            Cloud2.localPosition = StockC2;
        }

        //Reset Nuage 2-2
        if (Cloud22.localPosition.x >= 1250)
        {
            StockC22 = ResetC2;
            Cloud22.localPosition = StockC22;
        }

        //Reset Nuage 3
        if (Cloud3.localPosition.x >= 720)
        {
            StockC3 = ResetC3;
            Cloud3.localPosition = StockC3;
        }

        //Reset Nuage 3-2
        if (Cloud33.localPosition.x >= 720)
        {
            StockC33 = ResetC3;
            Cloud33.localPosition = StockC33;
        }
    }
    */
}
