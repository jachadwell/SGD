﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class TeleportTrigger : MonoBehaviour
{
    public enum TriggerType { Enter, Exit };

    [Tooltip("The Transform to teleport to")]
    [SerializeField] Transform teleportTo;

    [Tooltip("The filter Tag")]
    [SerializeField] string filtertag = "Player";

    [Tooltip("Trigger Event to Teleport")]
    [SerializeField] TriggerType type;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (type != TriggerType.Enter)
            return;
              
            other.transform.position = teleportTo.position;
                
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (type != TriggerType.Exit)
            return;

            other.transform.position = teleportTo.position;
        
    }
}