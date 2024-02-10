using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
//Sheldon Pacheco
namespace OtherNamespace
{
    public class MyObject
    {

    }
}
namespace GAME1001
{
    public class MyBackpack : MonoBehaviour
    {
        [SerializeField] TMP_Text myObjectLabel;
        [SerializeField] Button next;
        [SerializeField] Button previous;
        [SerializeField] Button add;
        [SerializeField] Button tree;
        [SerializeField] Button flower;
        [SerializeField] Button sound;
        [SerializeField] TMP_InputField name;
        [SerializeField] TMP_InputField power;
        OtherNamespace.MyObject o2 = new OtherNamespace.MyObject();
        List<MyObject> myObjects = new List<MyObject>();

        int current = -1;
        // Start is called before the first frame update
        void Start()
        {
            // myObject = new MyObject("flower",10);
            // Debug.Log(myObject.ToString());
            // myObjectLabel.text = myObject.ToString();
            if (myObjects.Count == 0)
            {
                myObjectLabel.text = "EMPTY";
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (current != -1 && myObjects.Count > 0)
            {
                MyObject o = myObjects[current];
                myObjectLabel.text = o.ToString();
            }
            else
            {
                myObjectLabel.text = "EMPTY";
            }
            
        }

        public void AddObject()
        {
            string name = this.name.text;
            string powerStr = this.power.text;
            int power = 0;
            //int power = int.Parse(powerStr);
            int.TryParse(powerStr, out power);
            if (name != "" && powerStr != "")
            {
                MyObject o = new LoudItem(name, power);//new MyObject(name, power);
                Debug.Log(o.ToString());
                myObjects.Add(o);
            }
            else
            {
                //myObjects.Add(MyObject.CreateFlower());
                MyObject o = new LaughItem();
                Debug.Log(o.ToString());
                myObjects.Add(o);
            }

            current = myObjects.Count - 1;
        }

        public void Next()
        {
            current++;
            if (current >= myObjects.Count)
            {
                current = myObjects.Count - 1;
            }
        }
        public void Previous()
        {
            current--;
            if (current < 0)
            {
                current = 0;
            }
        }
        public void MakeSound()
        {
            MyObject o = myObjects[current];
            Debug.Log(o.MakeSound());
        }
        public void Tree()
        {
            MyObject o = MyObject.CreateTree();
            myObjects.Add(o);
            current++;
        }
        public void Flower()
        {
            MyObject o = MyObject.CreateFlower();
            myObjects.Add(o);
            current++;
        }

    }
}
