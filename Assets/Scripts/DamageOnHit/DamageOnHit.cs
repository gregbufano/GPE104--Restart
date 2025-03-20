using UnityEngine;

public class DamageOnHit : MonoBehaviour
{

    public float damageToInflict;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
       StarshipHealth starshipHealth = collision.GetComponent<StarshipHealth>();

        if (starshipHealth != null)
        {
            starshipHealth.TakeDamage(damageToInflict);

            
        }
        
    }
}
