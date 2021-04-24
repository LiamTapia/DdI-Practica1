﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : InteractableXR
{
    public Vector3 offset;

    public override void Interact()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        if(player != null)
        {
            player.position = this.transform.position + offset;
        }
    }
}
