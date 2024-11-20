using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class HealthCollectable : MonoBehaviour
{
 [SerializeField] private float HealthValue;

 private void OnTriggerEnter2D(Collider2D collision)
 {
  if (collision.tag == "Player")
  {
   Debug.Log("Player collected");
   collision.gameObject.GetComponent<Health>().AddHealth(HealthValue);
   //gameObject.SetActive(false);
   Destroy(gameObject);
  }
 }
}
