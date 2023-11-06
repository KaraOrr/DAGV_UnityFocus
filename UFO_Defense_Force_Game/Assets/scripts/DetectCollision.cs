using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; //store reference to StoreManager
    public int scoreToGive;
    public soundBehavior soundScript;
    
    //

    //
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameObject and reference ScoreManager script Component
        soundScript = GameObject.Find("soundManager").GetComponent<soundBehavior>();
    }
    
    void OnTriggerEnter(Collider other)//Once the trigger has been entered record collision in the argument variable "other"
    {
        if (gameObject.CompareTag("UFO"))
        {
            Debug.Log("UFO audio");
            soundScript.PlayUFOSound();
            //explosionPart.Play();
            Debug.Log("ufo collison");
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject); //destroy this game object  
        }
        else if(gameObject.CompareTag("laser"))
        {
            Debug.Log("laser collison");
            Destroy(gameObject); //destroy this game object  
            Destroy(other.gameObject);
        }
        else if(gameObject.CompareTag("star"))
        {
            Debug.Log("star audio");
            soundScript.PlayStarSound();
            Debug.Log("other collison");
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
        } 
        else if(gameObject.CompareTag("Coin"))
        {
            Debug.Log("coin audio");
            soundScript.PlayCoinSound();
            Debug.Log("other collison");
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
        } 
    }
    

}
