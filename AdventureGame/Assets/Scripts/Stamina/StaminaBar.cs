using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class StaminaBar : MonoBehaviour
{
   
   public bool CanJump;
   [SerializeField] private Image staminaBar;
   [SerializeField] public float Stamina,staminaMax;
   public float AttackCost;
   public float ChargeRate;
   private Coroutine Recharge;

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      { 
         if (Stamina < .9) 
            CanJump = false;
         else 
            CanJump = true;
         if(Stamina < 0) Stamina = 0;
         staminaBar.fillAmount = Stamina/staminaMax;
         if(Recharge != null) StopCoroutine(Recharge);
         Recharge = StartCoroutine(RechargeStamina());
      }
      
   }

   private IEnumerator RechargeStamina()
   {
      yield return new WaitForSeconds(1f);
      while (Stamina < staminaMax)
      {
         Stamina += ChargeRate /10f;
         if(Stamina > staminaMax) Stamina = staminaMax;
         staminaBar.fillAmount = Stamina/staminaMax;
         yield return new WaitForSeconds(.1f);
      } 
      
   }
   public void ResetStamina()
   {
      Stamina = staminaMax;
      staminaBar.fillAmount = Stamina/staminaMax;
      Debug.Log("RESET STAMINA");
   }
}
