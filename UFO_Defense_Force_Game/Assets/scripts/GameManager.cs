using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
   // public int sceneToLoad;
    private GameObject gameOverText;
    void Awake()
    {
        
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        Debug.Log("startGM");
        //SceneManager.LoadScene(sceneToLoad); //Scene to Load
        Debug.Log("game restart");
    }

    void Update()
    {
        if(isGameOver)
        {
            EndGame(); //start endgame method
            Debug.Log("gameyover");
        }
        else
            gameOverText.gameObject.SetActive(false); //keep UI Text Game Over hidden
    }

    public void EndGame()
    {
        Debug.Log("endgame");
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; //Freeze Time
    }
}
