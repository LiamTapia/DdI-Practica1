using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject gameUI;
    public GameObject panel;

    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        _inventory.onChange += UpdateUI;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeSelf);
            gameUI.SetActive(!gameUI.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        Slot[] slots = GetComponentsInChildren<Slot>();
        Item[] equipItems = _inventory.GetAllItemsByType(ItemType.Equip);
        Item[] weaponItems = _inventory.GetAllItemsByType(ItemType.Weapon);
        Item[] materialItems = _inventory.GetAllItemsByType(ItemType.Materials);
        Item[] foodItems = _inventory.GetAllItemsByType(ItemType.Food);


        /*for(int i = 0; i < slots.Length; i++)
        {*/
        if(slots.Length > 0)
        {
            if(materialItems.Length > 0)    
                slots[0].SetItem(materialItems[0], materialItems.Length);
            else 
                slots[0].Clear();

            if(foodItems.Length > 0)
                slots[1].SetItem(foodItems[0], foodItems.Length);
            else 
                slots[1].Clear();
        }
        
            /*if(i < _inventory.items.Count)
                slots[i].SetItem(_inventory.items[i]);
            else
            {
                slots[i].Clear();
            }*/
        //}

        for(int i = 1; i < slots.Length; i++)
            if(i >= _inventory.items.Count)
                slots[i].Clear();
    }
}
