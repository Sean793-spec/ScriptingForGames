using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private UnityEngine.UI.Image HealthBarTotal;
   [SerializeField] private UnityEngine.UI.Image HealthBarCurrent;
   //Image = UnityEngine.UI.Image;

    private void Start()
    {
        HealthBarTotal.fillAmount = playerHealth.currentHealth / 10;
    }

    private void Update()
    {
        HealthBarCurrent.fillAmount = playerHealth.currentHealth / 10;
    }
}