using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Health playerHealth;

    [Header("Health")]
    private Text healthText;


    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<Health>();
        healthText = GameObject.Find("Health").GetComponent<Text>();

        float pHealth = playerHealth.currentHealth;
        healthText.text = "Health: " + playerHealth.currentHealth + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth()
    {
        Debug.Log("Heal event was called!");
        float healthPercentage = playerHealth.GetHealthPercent();

        healthText.text = "Health:" + healthPercentage + "%";
    }
}
