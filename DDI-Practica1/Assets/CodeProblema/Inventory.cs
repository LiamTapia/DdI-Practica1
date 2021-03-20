using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : MonoBehaviour
{
    static protected Inventory s_InventoryInstance;
    static public Inventory InventoryInstance{ get {return s_InventoryInstance;}}

    public delegate void OnInventoryChange();
    public OnInventoryChange onChange;

    public int space = 10;
    public List<Item> items = new List<Item>();

    private void Awake() 
    {
        s_InventoryInstance = this;
    }

    public Item[] GetAllItemsByType(ItemType type)
    {
        return items.Where(i => i.itemType == type).ToArray();
    }

    public void Add(Item newItem)
    {

        if(items.Count < space)
        {
            items.Add(newItem);
            if(onChange != null)
                onChange.Invoke();
        }
        else
            Debug.Log("Lista completa");
    }

    public void Remove(Item removeItem)
    {
        if(items.Contains(removeItem))
        {
            items.Remove(removeItem);
            if(onChange != null)
                onChange.Invoke();
        }
        else
            Debug.Log("Item no encontrado");
    }
}
