using UnityEngine;

public class CrashDMG : MonoBehaviour
{
   public float Damage = 5;
   public int ScoreIncreaseAmount;

   private void OnTriggerEnter2D(Collider2D collider2D){
    if (collider2D.gameObject.TryGetComponent<Health>(out Health component))
    {
        component.TakeDamage(Damage);
        
    }
   }
   void OnDestroy()
   {
        FindObjectOfType<GameManager>().ReduceAsteroidCountByOne();
        GameManager.instance.IncreaseScore(ScoreIncreaseAmount);
        
   }
}
