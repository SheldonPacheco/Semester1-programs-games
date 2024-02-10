using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
public class LabEx6 : MonoBehaviour
{
    List<int> numbers = new List<int>();
    List<string> words = new List<string>();
    List<Button> buttons = new List<Button>();
    List<List<int>> listoflist = new List<List<int>>();

    Dictionary<string, int> myDictionary = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);
        myDictionary.Remove("two");
        myDictionary.Add("two", 4);

        int x = myDictionary["one"];

        if (myDictionary.TryGetValue("two", out x))
        {
            Debug.Log(x);
        } else
        {
            Debug.Log("Key not found");
        }
        
        foreach(string k in myDictionary.Keys)
        {
            Debug.Log(k+": " + myDictionary[k]);
        }

        myDictionary.ContainsKey("one");
        myDictionary.ContainsValue(1);
    }
    private  void ListExample()
    {
        listoflist.Add(new List<int>());
        listoflist.Add(numbers);

        numbers.Add(1);
        numbers.Add(3);
        numbers.Add(5);
        numbers.Add(10);
        numbers.Add(11);
        numbers.Add(15);
        numbers.Insert(2, 12);

        words.Add("one");
        words.Add("two");

        foreach (int i in numbers)
        {
            Debug.Log(i);
        }

        int x = numbers[0];
        Debug.Log("--------------------------------------");
        Debug.Log(x);

        Debug.Log("--------------------------------------");
        numbers.Remove(10);
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }

        numbers.RemoveAll(isMoreThan10);

        Debug.Log("--------------------------------------");
        numbers.Remove(10);
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }

        Debug.Log(numbers.Find(isMoreThan10));

        Debug.Log("--------------------------------------");
        numbers.Remove(10);
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }

        Debug.Log(words.Find(isWordsMoreThan10));
        numbers.Add(100);
        if (numbers.Exists(isMoreThan10))
        {
            Debug.Log("Element Exists > 10");
        }
        else
        {
            Debug.Log("no elements > 10");
        }
    }
    private static bool isWordsMoreThan10(string x)
    {
        return false;
    }
    private static bool isMoreThan10(int x)
    {
        return x > 10;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
