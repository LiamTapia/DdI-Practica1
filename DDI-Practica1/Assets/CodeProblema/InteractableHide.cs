using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableHide : Interactable
{
    public int maxPosition = 4;
    public int index = 0;
    private float[] positionX = {35.44f,34.27f,47.26f,23.62f};
    private float[] positionZ = {108.0609f,119.6f,111.57f,115.31f};

    // Update is called once per frame
    public override void Update()
    {
        base.Update();        
    }

    public override void Interact()
    {
        index++;
        index %= maxPosition;
        transform.position = new Vector3(positionX[index], 1.26f, positionZ[index]);
    }
}
