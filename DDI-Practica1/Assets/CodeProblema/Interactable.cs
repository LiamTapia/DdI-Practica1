using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
//using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public bool isInsideZone = false;
    public KeyCode interactionKey = KeyCode.P;
    public string interactionButton = "Interact";
    //public GameObject ActionButton;

    public virtual void Update() 
    {

        //if(isInsideZone && Input.GetKeyDown(interactionKey))
        if(isInsideZone && CrossPlatformInputManager.GetButtonDown(interactionButton))
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
            //ActionButton.setActive(true);
        }
            
        return;
    }

    void OnMouseDown()
    {
        Interact();
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Salio del area de interaccion");
            isInsideZone = false;
            //ActionButton.enabled = false;
        }
            
        return;
    }

    public virtual void Interact()
    {

    }
}
