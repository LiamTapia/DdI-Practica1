using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableLight : Interactable
{
    public bool activeLight = false;
    public int speed = 1;
    Light lightComp;
    

    private void Start() {
        lightComp = GetComponent<Light> ();
        lightComp.enabled = false;
    }
    // Update is called once per frame
    public override void Update()
    {
        base.Update();        
        
    }

    public override void Interact()
    {
        activeLight = !activeLight;
        lightComp.enabled = activeLight;
    }
}
