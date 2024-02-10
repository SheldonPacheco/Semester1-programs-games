using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemBar : MonoBehaviour
{
    //Sheldon Pacheco
    [SerializeField] private TMP_Text currentItemLabel;
    [SerializeField] private TMP_Text currentPowerLabel;
    [SerializeField] private TMP_Text currentDescriptionLabel;
    [SerializeField] private TMP_Text totalMoneyLabel; 
    [SerializeField] private TMP_Text currentSlotLabel;
    [SerializeField] private TMP_Text playerGoldTxt;
    private List<Items> myItems = new List<Items>();
    private int current =0;
    private float playerMoney = 1000;


    void Start()
    {
        current = 0;
        DisplayItem();
    }

    public bool AddToHotBar(Items item)
    {
        if (myItems.Count < 9)
        {
            myItems.Add(item);
            current = myItems.Count - 1;
            DisplayItem();
            return true;
        }
        else
        {
            Debug.Log("HotBar is full, remove some items");
            return false;
        }
    }

    public void DisplayItem()
    {
        if (myItems.Count > 0)
        {
            Items item = myItems[current];
            currentItemLabel.text = "Name: " + item.GetName();
            currentPowerLabel.text = "Power: " + item.GetPower().ToString();
            currentDescriptionLabel.text = "Description: " + item.GetDescription();
        }
        else
        {
            currentItemLabel.text = "No Items";
            currentPowerLabel.text = "";
            currentDescriptionLabel.text = "";
        }
    }

    public void NextItem()
    {
        
        if (current >= myItems.Count-1)
        {
            current = myItems.Count-1;

        }
        else
        {
            current++;
        }
        DisplayItem();
    }

    public void PreviousItem()
    {
        current--;
        if (current < 0)
        {
            current = 0;

        }

        DisplayItem();
    }

    public void RemoveFromHotBar()
    {
        if (current < myItems.Count)
        {
            Items item = myItems[current];   
            if (item.TimesBought() > 1)
            {
                myItems.RemoveAll(i => i == item);
                playerMoney += item.GetCost();
                current = myItems.Count-1;
            }
            else
            {
                myItems.Remove(item);
                playerMoney += item.GetCost();
                current = myItems.Count-1;
            }

            ItemShop itemShop = FindObjectOfType<ItemShop>();
            itemShop.isOwnedLabel.text = "Not Owned";
            item.SetOwned(false);
            DisplayItem();
        }
        else
        {
            Debug.Log("Hotbar is empty, cannot sell.");
        }
    }
    public void MinusPlayerMoney(float cost)
    {
        playerMoney -= cost;
        
    }
    public void Update()
    {    
        currentSlotLabel.text = "Slot: "+current.ToString();
        playerGoldTxt.text = "Player Gold: " + playerMoney.ToString();
        if (current <0)
        {
            current = 0;
        }
    }
    public float GetPlayerMoney()
    {
        return playerMoney;
    }
}
