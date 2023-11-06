using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    
    public float speed = 25;
    
    public float xRange = 23;
    //audio
    public AudioClip shootSound;
    public AudioClip explodeSound;
    private AudioSource playerAudio;
    //
    public Transform blaster;
    
    public GameObject lazerBolt;
    
    public GameManager gameManager;

    public ParticleSystem explosionParticle;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }
    void Update()
    {
    //set horizontal input to recieve values from keyboard
    horizontalInput = Input.GetAxis("Horizontal");
    
    //moves player left and right
    transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    
    //keep player within boundaries
    //left side wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
    //right side wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        //space = fire laser bolt
        if(Input.GetKeyDown(KeyCode.Space)) //&& gameManager.isGameOver == false)
        {
            //create laserbolt at the blaster transform position maintaining the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
            playerAudio.PlayOneShot(shootSound, 1.0f);
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("UFO"))
        {
            Debug.Log("bad collision");
            speed = 0;
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameManager.isGameOver = true;
            explosionParticle.Play();
        }
        else
        {
            Debug.Log("potatoes");
            Destroy(other.gameObject);
        }
    }
}



//make sure to buy rootbeer (a pershon of culture)