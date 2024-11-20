using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaCollectable : MonoBehaviour
{
    [SerializeField] private StaminaBar staminaBar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<StaminaBar>().ResetStamina();
            Destroy(gameObject);
        }
    }
}
