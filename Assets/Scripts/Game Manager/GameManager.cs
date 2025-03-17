using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UIManager uiManager;
    

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
 void start()
{
 
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

public void IncreaseScore(int amount)
{
score += amount;
uiManager.UpdateText("" + score);
}

void TriggerWin()
{
    Debug.Log("You Win");
}
void TriggerLoss()
{
  Debug.Log("You Lose");
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
