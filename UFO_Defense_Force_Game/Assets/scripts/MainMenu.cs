using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public soundBehavior soundScript;
    void Start()
    {
        soundScript = GameObject.Find("SoundManager").GetComponent<soundBehavior>();
    }
    public void StartGame()
    {
        soundScript.PlayStartSound();
        SceneManager.LoadScene(sceneToLoad); //Scene to Load
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        soundScript.PlayQuitSound();
        Debug.Log("Quit Game!");
        Application.Quit();
    }
}

//menu button sounds