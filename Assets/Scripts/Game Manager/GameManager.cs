using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public void Awake()
    {
        instance = this;

      
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
