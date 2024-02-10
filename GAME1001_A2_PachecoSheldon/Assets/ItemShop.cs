using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemShop : MonoBehaviour
{
    //Sheldon Pacheco
    [SerializeField] private TMP_Text itemNameLabel;
    [SerializeField] private TMP_Text itemCostLabel;
    [SerializeField] private TMP_Text itemPowerLabel;
    [SerializeField] private TMP_Text itemDescriptionLabel;
    [SerializeField] public TMP_Text isOwnedLabel;
    [SerializeField] private List<Items> myItems = new List<Items>();
    [SerializeField] private int current = 0;

    void Start()
    {
        myItems.Add(Items.PowerfulStaff());
        myItems.Add(Items.BasicSword());
        myItems.Add(Items.BasicBow());
        myItems.Add(Items.ManaPotion());
        myItems.Add(Items.HealthPotion());
        current = 0;
        DisplayItem();

    }

    public void DisplayItem()
    {
        if (myItems.Count > 0)
        {
            Items item = myItems[current];
            itemNameLabel.text = "Name: " + item.GetName();
            itemCostLabel.text = "Cost: " + item.GetCost().ToString()+" gold";
            itemPowerLabel.text = "Damage: " + item.GetPower().ToString();
            itemDescriptionLabel.text = "Description: " + item.GetDescription();
            if (!item.IsOwned())
            {
                isOwnedLabel.text = "Not Owned";
            }
            else
            {
                isOwnedLabel.text = "Owned";
            }

        }
        else
        {
            itemNameLabel.text = "No items";
            itemCostLabel.text = "";
            itemPowerLabel.text = "";
            itemDescriptionLabel.text = "";
        }
    }

    public void NextItem()
    {
        current++;
        if (current > 4)
        {
            current = 4;

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

    public void AddToHotBar()
    {

            Items item = myItems[current];
            ItemBar itemBar = FindObjectOfType<ItemBar>();//intializes the script due to it not being static and some methods being static

            if (itemBar.GetPlayerMoney() >= item.GetCost() || item.IsOwned())
            {
                itemBar.AddToHotBar(item);//checks if hotbar is full from itembar script
                if (!item.IsOwned())//sets item as owned
                {

                    itemBar.MinusPlayerMoney(item.GetCost());
                    item.SetOwned(true);
                    isOwnedLabel.text = "Owned";
                    item.TimesBought();


                }
            }
            else
            {
                Debug.Log("Not enough gold!");
            } 
    }
}

