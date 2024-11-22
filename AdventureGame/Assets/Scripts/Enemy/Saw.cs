using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Saw : MonoBehaviour
{
    public Animator anim;
    public Health playerHealth;
    [SerializeField] private float damage;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            anim.SetTrigger("Off");
           StartCoroutine(AnimationTimer(3f));
        }
        
    }

    private IEnumerator AnimationTimer(float time)
    {
        yield return new WaitForSeconds(time);
       anim.SetTrigger("On");
    }
}
