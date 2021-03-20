using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public Image image;

    public int itemCount = 0;
    public Text xText;
    public Text CounterText;

    public HeartController hcontrol;

    void Start()
    {
        /*if(image != null && item != null)
        {
            image.sprite = item.icon;
        }*/
    }

    public void SetItem(Item item, int count)
    {
        this.item = item;
        itemCount = count;

        if(image != null)
        {
            image.enabled = true;
            xText.enabled = true;
            CounterText.enabled = true;
            image.sprite = item.icon;
        }

        if(CounterText != null)
            CounterText.text = count.ToString();
    }

    public void Clear()
    {
        this.item = null;
        //image.sprite = defaultSprite;
        image.enabled = false;
        CounterText.enabled = false;
        xText.enabled = false;
        
        
    }

    public void UseItem()
    {
        if(this.item != null)
        {
            if(this.item.itemType == ItemType.Materials || this.item.itemType == ItemType.Food)
                hcontrol.UpdateLife(item.Cure());

            item.Use();
            if(itemCount > 0)
                itemCount--;
            if(CounterText != null)
                CounterText.text = itemCount.ToString();
        }

        if(itemCount == 0)
        {
            image.sprite = null;
            image.enabled = false;
            CounterText.enabled = false;
            xText.enabled = false;
        }

        Inventory.InventoryInstance.Remove(this.item);
    }
}
