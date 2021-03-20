using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rupee : MonoBehaviour
{
    public int RupeeValue = 1;
    public RupeeCounter rupeeAction;
     

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Entro en el area de interaccion");
            rupeeAction.UpdateCount(RupeeValue);
            Destroy(this.gameObject);
        }
            
        return;
    }
}
