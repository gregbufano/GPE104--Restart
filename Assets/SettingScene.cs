using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingScene : MonoBehaviour
{
    public string settingScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gettingToScene()
    {
        SceneManager.LoadScene(settingScene);
    }
}
