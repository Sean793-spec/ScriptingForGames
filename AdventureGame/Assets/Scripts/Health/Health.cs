using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [Header ("Health")]
   private static readonly int Hit = Animator.StringToHash("Hit");
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator animator;
    private void Awake()
    {
        currentHealth = startingHealth; 
        animator = GetComponent<Animator>();
       // anim = GetComponents<Animator>();
    }
  
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth > 0)
        {
            animator.SetTrigger("Hit");
            //Anim[(int)Hit].SetTrigger("Hit Animation");
           
        }
        else
        {
            if (currentHealth <= 0)
            {
                 SceneManager.LoadScene(0);
            }
           
        }
    }
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
            TakeDamage(1);
    }

    public void AddHealth(float _Value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _Value, 0, startingHealth);
    }
  
   
}
