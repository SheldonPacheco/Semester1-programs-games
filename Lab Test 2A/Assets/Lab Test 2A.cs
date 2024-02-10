using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEditor.VersionControl;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_InputField userinput;
    [SerializeField] TMP_Text displayText;
    [SerializeField] TMP_Text displayText2;
    int timestodisplay;
    int count;
    int timesdone=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void submit()
    {
        if (userinput.text != "" && int.TryParse(userinput.text, out timestodisplay))
        {
            if (timestodisplay >= 1 && timestodisplay < 31 && timesdone <5)
            {
                //timestodisplay = int.Parse(userinput.text);
                displayText2.text = "user entered: " + userinput.text;
                while (count < timestodisplay)
                {
                    displayText.text += "*";
                    count++;
                }
                displayText.text += " \n";
                count = 0;
                userinput.text = "";
                timesdone++;
            } else {
                displayText2.text = "enter vaild input, value too high 1 - 30. or reched maxed times";
                userinput.text = "";
            }
        }
        else
        {
            displayText2.text = "enter vaild input";
        }

    }
}
