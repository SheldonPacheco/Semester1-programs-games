using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class LabEx5 : MonoBehaviour
{
    [SerializeField] private TMP_Text outputText;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] Button button;

    const int ISIZE = 10;
    int[] arr = new int[ISIZE];

    private bool wasPrinted = false;

    int cnt = 0;
    int val = 0;
    public void additem()
    {
        string str = inputField.text;
        bool success = int.TryParse(str, out val);
        if (success & cnt<ISIZE)
        {
            arr[cnt] = val;
            cnt++;
            inputField.text = "";
            Debug.Log("added: " + val);
        } else if (cnt>=ISIZE)
        {
            inputField.text = "your array is full.";
        }else 
        {
            inputField.text = "please enter a valid intager";
        }
          
    }
    public void Reset() {
        cnt = 0;
        isPrinting = false;
        wasPrinted = false;
        for (int i = 0; i < arr.Length; i++){
            arr[i] = 0;
        }
        inputField.text = "";
        outputText.text = "";
        button.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        outputText.enabled = false;
        button.gameObject.SetActive(false);
    }
    bool isPrinting = false;
    IEnumerator PrintValues()
    {
            isPrinting = true;
            outputText.text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                outputText.text += " " + arr[i];
                yield return new WaitForSeconds(.5f);
            }
            wasPrinted = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!wasPrinted && cnt>=ISIZE  && !isPrinting)
        {
                StartCoroutine(PrintValues());
                outputText.enabled =true;
                button.gameObject.SetActive(true);
        }
    }
}
