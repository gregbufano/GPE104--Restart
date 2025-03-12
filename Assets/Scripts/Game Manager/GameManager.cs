using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string enemyTag = "Asteroid";
    private int totalEnemies; // Total number of Asteroids
    private int enemiesDestroyed = 0; // Number of destroyed enemies

    public int lives = 3;
    
   
    public void Awake()
    {
      if(instance == null){
        instance = this;
        DontDestroyOnLoad(gameObject);
      }
      else
      {
        Destroy(gameObject);
      }
        

      
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
 void start()
{
    totalEnemies = GameObject.FindGameObjectsWithTag(enemyTag).Length;
}
public void EnemyDestroyed()
{
    enemiesDestroyed++;

    if (enemiesDestroyed >= totalEnemies)
    {
        TriggerWin();
    }
}
void TriggerWin()
{
    Debug.Log("You Win");
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintHello()
    {
       
        
          Debug.Log("Hello");
        
       
    }
}
