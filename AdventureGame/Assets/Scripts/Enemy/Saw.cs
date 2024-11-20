using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Saw : MonoBehaviour
{
    private Animator anim;
    public Health playerHealth;
    [SerializeField] private float damage;

   private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            
        }
        
    }
}
