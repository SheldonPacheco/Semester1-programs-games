using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
//Sheldon Pacheco
//101350324
public class Labtest3 : MonoBehaviour
{
    List<int> list = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        intlist(list);
        printlist(list);

        Debug.Log("list doubled");
        printlist(doubleAll(list));

        Debug.Log("sum of all odd numbers");
        printlist(sumOdd(list));

        Debug.Log("High and Low even numbers");
        printlist(getHighLowEven(list));

        Debug.Log("List after skipping by 2");
        printlist(skipBy(list));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void intlist(List<int> l, int size = 10)
    {

        for (int i = 0; i < size; i++)
        {
            l.Add(Random.Range(1, 101));
        }

    }
    List<int> doubleAll(List<int> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            l[i] *= 2;

        }
        return l;
    }


    List<int> sumOdd(List<int> l)
    {
        List<int> l2 = new List<int>();
        int sum = 0;
        foreach (int i in l)
        {
            if ((i / 2) % 2 != 0) //divided by 2 to account fo doubling of elements
            {
                 sum += i / 2;
            }
        }

        l2.Add(sum);

        return l2;
    }
    List<int> getHighLowEven(List<int> l, int high = int.MinValue, int low = int.MaxValue)
    {
        List<int> l2 = new List<int>();

        foreach (int i in l)
        {
            if (i % 2 == 0)
            {
                if (i > high)
                {
                    high = i;
                }
                if (i < low)
                {
                    low = i;
                }
            }
        }

        l2.Add(high);
        l2.Add(low);

        return l2;
    }

    List<int> skipBy(List<int> l, int step=2)
    {
        List<int> l2 = new List<int>();
        for (int i = 0; i < l.Count; i += step)
        {
            l2.Add(l[i]);
        }

        return l2;
    }

    void printlist(List<int> l)
    {
        foreach (int i in l)
        {
            Debug.Log(i);


        }
    }

}
