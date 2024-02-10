using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Xml.Schema;
using UnityEngine;

public class Lab2ex : MonoBehaviour
{
    [SerializeField]
    int hoursWorked = 0;

    [SerializeField]
    float hourlyRate = 0.0f;

    private int prevHours = 0;
    private float prevRate = 0.0f;

    int discount = 15;
    double totalSqaureMeters = 0.0;
    double area = 150;
    double price = 10;
    const string msg = "The price is: $ ";
    // Start is called before the first frame update
    void Start()
    {
        totalSqaureMeters = area * price * (-100 * discount) / 100;
        Debug.Log(msg + totalSqaureMeters);
    }
    
    // Update is called once per frame
    void Update()
    {
        float totalPay = 0, regularPay = 0, overTimePay = 0;
        if (prevHours != hoursWorked || prevRate != hourlyRate)
        {
            if (hoursWorked <= 40)
            {
                regularPay = hoursWorked * hourlyRate;
            }
            else
            {
                regularPay = 40 * hoursWorked;
                overTimePay = (hoursWorked - 40) * hourlyRate *1.5f;
            }

            totalPay = regularPay + overTimePay;
            Debug.Log("Regular Pay: $" + regularPay);
            Debug.Log("Overtime Pay: $" + overTimePay);
            Debug.Log("Total Pay: $" + totalPay);

            prevRate = hourlyRate; 
            prevHours = hoursWorked;
        }
    }
}
