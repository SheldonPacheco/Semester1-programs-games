using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lab2 : MonoBehaviour
{
    [SerializeField]
    double sqaureMeters = 0;
    [SerializeField]
    double price = 0;

    const double discount = 0.15;
    const string message = "The price is: $";

    private double prevPrice = 0;
    private double prevSqaureMeters = 0;
    private double prevdiscountValue = 0;
    private double prevTotalValue = 0;

    double totalSqaureMeters = 0;
    double discountValue = 0;
    double totalValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (prevPrice != price || prevSqaureMeters != sqaureMeters || prevdiscountValue != discountValue || totalValue != prevTotalValue)
        {
            if (sqaureMeters > 100)
            {
                totalSqaureMeters = sqaureMeters * price;
                discountValue = totalSqaureMeters * discount;
                Debug.Log(message + (totalValue = totalSqaureMeters - discountValue));
            }
            else
            {
                Debug.Log(message + (totalSqaureMeters = sqaureMeters * price));
            }
            prevPrice = price;
            prevSqaureMeters = sqaureMeters;
            prevdiscountValue = discountValue;
            prevTotalValue = totalValue;
        }

    }
}
