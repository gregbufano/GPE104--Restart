using UnityEngine;

public class AlienCollision : MonoBehaviour

{
   public float Damage = 5;
   private GameObject player;

   void Start()
   {
     player = GameObject.FindGameObjectWithTag("Player");
   }

   private void OnTriggerEnter2D(Collider2D other){
    if (other.gameObject.tag == "Player")
    {
         if (GetComponent<Collider2D>().gameObject.TryGetComponent<Health>(out Health component) )
    {
        component.TakeDamage(Damage);
        
    }
    }
    
   }
   
}

