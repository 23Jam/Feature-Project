using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //public Image healthText;
    
    private Shield shield;

    //public GameObject gameOver;
    //public float health;
    //public Text text;

    //public GameObject shieldPrefab;
    //private float fillAmount;

    public int maxHealth = 3;
    public int currentHealth; 

    // Start is called before the first frame update
    void Start()
    {
        //health = 10f;
        //healthText.fillAmount = health;
        //gameOver.SetActive(false);
        //shield = GetComponent<Shield>();
        currentHealth = maxHealth;
    }

    /*
    void Update()
    {
        text.text = "Health :" +health;    
    }
    */
    void TakeDamage(int amount)
    {
        //health -= amount;
        //healthText.fillAmount = health;
        currentHealth -= amount;
        
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (!sheild.ActiveShield)
        {
            if(other.tag == "Arrow")
            {
                TakeDamage(1f);
            }

            if(health <= 0)
            {
                shieldPrefab.SetActive(false);
                Time.timeScale = 0;
                //gameOver.SetActive(true);
            }
            
        }
    }
    */
}
