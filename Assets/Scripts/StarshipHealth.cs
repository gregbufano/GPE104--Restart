using UnityEngine;

public class StarshipHealth : MonoBehaviour
{

    public float currentHealth;
    public float maxHealth;

    public UpdateHealthbar healthBarFiller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (healthBarFiller != null)
        {
            healthBarFiller.ChangeFillAmount();
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void heal(float amount)
    {
        currentHealth += amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (healthBarFiller != null)
        {
            healthBarFiller.ChangeFillAmount();
        }
    }

    public void Die()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ReduceLiveByOne();
        }
        Destroy(gameObject);
    }
}
