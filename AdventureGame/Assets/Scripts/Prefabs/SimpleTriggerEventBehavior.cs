using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class NewBehaviourScript : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private void onTriggerEnter(Collider other)
        {
        triggerEvent.Invoke();
        Debug.Log("Player interacting with Object");
 }      
}
