using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] [Range(1f, 200f)] private float maxHealth;
    [SerializeField] [Range(1f, 100f)] private float initialHealth;

    public float currentHealth;
    private float healthPercentage;

    [Header("Events")]
    [SerializeField, Tooltip("Raised everytime the object is healed")] private UnityEvent onHeal;
    [SerializeField, Tooltip("Raised everytime the object is damaged")] private UnityEvent onDamage;
    [SerializeField, Tooltip("Raised everytime the object dies")] private UnityEvent onDie;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(float damage)
    {
        
    }

    public void Heal(float health)
    {
        if (currentHealth < 100)
        {
            currentHealth += health;

            if (currentHealth > 100)
            {
                currentHealth = 100;
            }
            
        }

        onHeal.Invoke();
    }
        

        

    public float GetHealthPercent()
    {
        healthPercentage = currentHealth / maxHealth;
        healthPercentage = healthPercentage * 100;
        return healthPercentage;
    }
}
