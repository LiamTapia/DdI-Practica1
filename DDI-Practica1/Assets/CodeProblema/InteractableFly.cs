using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableFly : Interactable
{
    public bool used = false;
    public int speed = 1;

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        /*Al interactuar con el objeto se mueve para arriba*/
        if(used)
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
        Destroy(GetComponent<BoxCollider>());
    }
}
