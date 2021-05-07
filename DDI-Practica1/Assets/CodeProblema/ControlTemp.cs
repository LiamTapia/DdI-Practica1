using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTemp : InteractableXR
{
    public TemperatureSensor sensor;
    public float numberChange;

    public override void Interact()
    {
        sensor.changeTemp(numberChange);
    }
}
