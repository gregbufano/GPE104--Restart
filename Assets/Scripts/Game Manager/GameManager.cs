using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIManager uiManager;
    // random enemy spawn
    public int enemiesSpawned;
    public GameObject enemyPrefab; // Drag your enemy prefab into this slot
    public GameObject secondEnemyprefab;
    public float spawnAreaWidth = 10f; // Set the width of the spawn area
    public float spawnAreaHeight = 5f; // Set the height of the spawn area
    public float spawnDistance;
    public string loseScene;
    public string winScene;
    
    

    public int lives = 3;
    public int asteroidCount = 2;

    public int score = 0;

    
   
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
 void Start()
{
  SpawnEnemy();
}
public void ReduceLiveByOne()
{
  lives--;
  if (lives <= 0)
  {
    TriggerLoss();
  }
}

public void ReduceAsteroidCountByOne()
{
  asteroidCount--;
  if (asteroidCount<= 0)
  {
    TriggerWin();
  }
}
public void IncreaseAsteroidCountByOne()
{
  asteroidCount++;
}

public void IncreaseScore(int amount)
{
score += amount;
uiManager.UpdateText("" + score);
}

void TriggerWin()
{
    Debug.Log("You Win");
    SceneManager.LoadScene(winScene);
}
void TriggerLoss()
{
  Debug.Log("You Lose");
  SceneManager.LoadScene(loseScene);
}

public void SpawnEnemy()
    {
        for (int i = 0;i< 5; i++)
        {
            // Generate a random x and y position within the spawn area
        float randomX = Random.Range(-spawnAreaWidth, spawnAreaWidth);
        float randomY = Random.Range(-spawnAreaHeight, spawnAreaHeight);
        
        Vector3 spawnPosition = new Vector3(randomX, 0, randomY); // Assuming 2D, modify for 3D

        // Instantiate the enemy at the random position
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            GameObject secondEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            Debug.Log("Enemy Spawned");
        
        }
        
       
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
