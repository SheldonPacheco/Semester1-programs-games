using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Sheldon Pacheco
 * September 25th, 2023
 */
public class Labtest1 : MonoBehaviour
{
    [SerializeField]
    double totalMoneySold = 0;


    const double discount1 = 0.09;
    const double discount2 = 0.15;

    private double prevTakeHomePay = 0;
    private double prevTotalMoneySold = 0;
    private double takeHomePay = 0;
 
    private double overflowMoneySold = 0;
    private double prevOverflowMoneySold = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (prevTakeHomePay != takeHomePay || prevTotalMoneySold != totalMoneySold || prevOverflowMoneySold != overflowMoneySold)
        {
            if (totalMoneySold <= 2000 && totalMoneySold > 0)
            {
                Debug.Log("Total money eraned: " + (takeHomePay = totalMoneySold * discount1 + 200));
            }
            else
            {
                overflowMoneySold = 2000;
                takeHomePay = overflowMoneySold * discount1 + 200;
                overflowMoneySold = -2000 + totalMoneySold;
                Debug.Log("Total money eraned: " + (takeHomePay += overflowMoneySold * discount2));
            }
            prevTotalMoneySold = totalMoneySold;
            prevTakeHomePay = takeHomePay;
            prevOverflowMoneySold = overflowMoneySold;
            
        }

    }
}
