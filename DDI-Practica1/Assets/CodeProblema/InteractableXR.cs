using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
//using UnityEngine.UI;
using IBM.Watsson.Examples;

public class InteractableXR : MonoBehaviour
{
    
    public bool isInsideZone = false;
    public KeyCode interactionKey = KeyCode.P;
    public string interactionButton = "Interact";

    /*GazeXR*/
    public bool gazedAt;
    public float gazeTimer = 0;
    public float gazeInteractTime = 15f;
    public string voiceCommand = "jump";

    void Awake() 
    {
        VoiceCommandProcessor commandProcessor = GameObject.FindObjectOfType<VoiceCommandProcessor>();
        commandProcessor.onVoiceCommandRecognized += OnVoiceCommandRecognized;
    }
    public virtual void Update() 
    {

        //if(isInsideZone && Input.GetKeyDown(interactionKey))
        if(isInsideZone && CrossPlatformInputManager.GetButtonDown(interactionButton))
        {
            Interact();
        }

        if(gazedAt)
        {
            if((gazeTimer += Time.deltaTime) >= gazeInteractTime)
            {
                Interact();
                gazedAt = false;
                gazeTimer = 0f;
            }
        }
    }

    public void OnVoiceCommandRecognized(string command)
    {
        //if(command.ToLower() == OnVoiceCommandRecognized.ToLower() && gazedAt)
        if(command.ToLower().Contains(voiceCommand.ToLower()) && gazedAt)
        {
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

    /*void OnMouseDown()
    {
        Interact();
    }*/
    public void SetGazedAt(bool gazedAt)
    {
        this.gazedAt = gazedAt;
        if(!gazedAt)
        {
            gazeTimer = 0f;
        }
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
