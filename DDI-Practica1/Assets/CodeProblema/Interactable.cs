using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInsideZone = false;
    public KeyCode interactionKey = KeyCode.P;

    public virtual void Update() 
    {
        if(isInsideZone && Input.GetKeyDown(interactionKey))
        {
            Debug.Log("Tecla presionada");
            Interact();
        }
            
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Entro en el area de interaccion");
            isInsideZone = true;
        }
            
        return;
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Salio del area de interaccion");
            isInsideZone = false;
        }
            
        return;
    }

    public virtual void Interact()
    {

    }
}
