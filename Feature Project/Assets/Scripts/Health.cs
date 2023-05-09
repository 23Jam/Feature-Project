using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthText;

    private Shield shield;
    private float health;

    public GameObject shieldPrefab;
    //private float fillAmount;

    // Start is called before the first frame update
    void Start()
    {
        health = 10f;
        healthText.fillAmount = health;
        shield = GetComponent<Shield>();
    }

    void TakeDamage(float amount)
    {
        health -= amount;
        healthText.fillAmount = health;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!shield.ActiveShield)
        {
            if(other.tag == "Arrow")
            {
                TakeDamage(1f);
            }

            if(health <= 0)
            {
                shieldPrefab.SetActive(false);
            }
            
        }
    }
}
