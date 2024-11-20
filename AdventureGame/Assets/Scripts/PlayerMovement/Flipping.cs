using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Flipping : MonoBehaviour
{
    public KeyCode Key1 = KeyCode.RightArrow, key2 = KeyCode.LeftArrow;
    public float direction1 = 0, direction2 = 180; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Key1))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }
        if(!Input.GetKeyDown(key2)) return;
        {
            transform.rotation = Quaternion.Euler(0, direction2, 0);
        }
    }
}
