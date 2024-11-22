using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Single Varibles/Simple Float Data")]
public class SimpleIntData : MonoBehaviour
{
   public float value;

   public void UpdateValue(int amount)
   {
       value += amount;
   }

   public void SetValue(int amount)
   {
       value = amount;
   }
}
