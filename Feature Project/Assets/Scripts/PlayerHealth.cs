using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    /*
    public int current;
    public int max;
    public Text healthText;
    bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        current = max;
    }

    // Update is called once per frame
    void Update()
    {
        //current -= 1;
        healthText.text = current.ToString() + " / " + max.ToString();

        if(current < 0)
        {

        }

        if(other.gameObject.tag == "Arrow")
        {
            current -= 1;
        }
    }
    */
    
    [SerializeField] private Text healthText;
    private const float maxHealth = 10;
    [SerializeField][Range(0, 10)] private float currentHealth;

    public void UpdatePlayerHealth()
    {
        healthText.text = "Health " + currentHealth.ToString("0") + "/" + maxHealth;
    }

    private void Update()
    {
        UpdatePlayerHealth();
    }
}
