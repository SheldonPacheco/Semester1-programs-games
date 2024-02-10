using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class La3ex : MonoBehaviour
{
    [SerializeField]
    bool flip =false;
    [SerializeField]
    int start = 1;
    [SerializeField]
    int end = 10;
    [SerializeField]
    int skip = 3;
    [SerializeField]
    int end2 = 0;

    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("while loop");
        while (counter <= 5)
        {
            Debug.Log("this is while a loop"+counter);
            counter++;
        }
        Debug.Log("do while loop");
        counter = 0;
        do {
            Debug.Log("this is a do while loop" + counter);
            counter++;
        } while (counter <= 5);
        Debug.Log("this is a for loop");
        for (int i = start; i<=end; i+=skip)
        {
            Debug.Log(i);
        }
        counter = 0;
        Debug.Log("break");
        while (true)
        {
            Debug.Log("break lop" + counter);
            counter++;
            if (counter >= 15)
            break;
            Debug.Log("Other code to execute");
        }
        counter = 0;
        Debug.Log("continue");
        while (counter<=15)
        {
            Debug.Log("break lop" + counter);
            counter++;
            if (counter%3 ==0)
                continue;
            Debug.Log("Other code to execute");
        }
        counter = 0;
        for (int i2 = 1; i2 <= end2; i2 += 1)
        {
            Debug.Log("*");
        }
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
