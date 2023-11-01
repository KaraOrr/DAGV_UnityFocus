using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; //store reference to StoreManager
    public int scoreToGive;
    public GameManager gameManager;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameObject and reference ScoreManager script Component
    }

    void OnTriggerEnter(Collider other)//Once the trigger has been entered record collision in the argument variable "other"
    {
        if (gameObject.CompareTag("UFO"))
        {
            Debug.Log("ufo collison");
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(other.gameObject);
            Destroy(gameObject); //destroy this game object  
        }
        else
        {
            Debug.Log("other collison");
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
        } 
    }

}
