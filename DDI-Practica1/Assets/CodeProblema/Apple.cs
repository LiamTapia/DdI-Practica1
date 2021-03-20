using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Apple", menuName="Inventory/Apple")]

public class Apple : Item
{
    //public HeartController hcontrol;
    public int lifeAmount = 1;
    public int effectiveness = 1;

    public override void Use()
    {
        base.Use();
        Debug.Log($"Aumenta vida en {lifeAmount}");

       // hcontrol.UpdateLife(lifeAmount);
    }    

    public override int Cure()
    {
        return lifeAmount;
    }   
}
