using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyXR : InteractableXR
{
    public bool used = false;
    public bool willFly = false;
    public int speed = 1;
    public Light lightComp;
    public bool activeLight = false;
    public AudioSource source;

    private void Start() 
    {
        //lightComp = GetComponent<Light> ();
        lightComp.enabled = false;
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        /*Al interactuar con el objeto se mueve para arriba*/
        if(used && willFly)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);

            /*Al llegar a cierta altura se destruye*/
            if (transform.position.y >= 20)
                Destroy(gameObject);
        }
        
    }

    public override void Interact()
    {
        used = true;
        /*Quita el Boxcollider al presionarse la tecla*/
        //Destroy(GetComponent<BoxCollider>());
        
        activeLight = !activeLight;
        lightComp.enabled = activeLight;
        source.Play();
    }
}
