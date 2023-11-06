using UnityEngine;

public class destroyOUTOFBOUNDS : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -20.0f;
    public soundBehavior soundScript;
    private GameManager gameManager;

    void Start()
    {
        soundScript = GameObject.Find("soundManager").GetComponent<soundBehavior>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds && gameObject.CompareTag("UFO"))
        {
            Debug.Log("outofbounds");
            soundScript.PlayOutSound();
            //if ufo out of bounds
            Time.timeScale = 0;
            //enable gameovertext
            gameManager.isGameOver = true;
            Destroy(gameObject); 
            
        }
        else if(transform.position.z < lowerBounds && gameObject.CompareTag("Coin"))
        {
            Debug.Log("coin/star out of bounds");
            Destroy(gameObject); 
        }
        else if(transform.position.z < lowerBounds && gameObject.CompareTag("star"))
        {
            Debug.Log("coin/star out of bounds");
            Destroy(gameObject); 
        }
    }
}
