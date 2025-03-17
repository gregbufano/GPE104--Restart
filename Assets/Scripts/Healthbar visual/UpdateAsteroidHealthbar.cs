using UnityEngine;
using UnityEngine.UI;
public class UpdateAsteroidHealthbar : MonoBehaviour
{

    public Image healthBar;

    public Health health;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeFillAmount()
    {
        if (healthBar != null && health != null)
        {
            float healthPercent = health.currentHealth / health.maxHealth;
            healthBar.fillAmount = healthPercent;
        }
    }
}
