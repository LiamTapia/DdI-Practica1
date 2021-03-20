using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Roasted Fruit", menuName="Inventory/RoastedFruit")]
public class RoastedFruit : Item
{
    public int lifeAmount = 3;
    public int effectiveness = 1;
    public override void Use()
    {
        base.Use();
        Debug.Log($"Aumenta vida en {lifeAmount}");
    }  

    public override int Cure()
    {
        return lifeAmount;
    }
}
