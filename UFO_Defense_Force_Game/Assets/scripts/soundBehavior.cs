using UnityEngine;

public class soundBehavior : MonoBehaviour
{
    private AudioSource objectAudio;
    public AudioClip UFOSound;
    public AudioClip CoinSound;
    public AudioClip StarSound;
    public AudioClip OutSound;
    //menu:
    public AudioClip StartSound;
    public AudioClip QuitSound;

    void Start()
    {
        objectAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayUFOSound()
    {
        objectAudio.PlayOneShot(UFOSound, 1.0f);
    }
    public void PlayCoinSound()
    {
        objectAudio.PlayOneShot(CoinSound, 1.0f);
    }
    public void PlayStarSound()
    {
        objectAudio.PlayOneShot(StarSound, 1.0f);
    }
    public void PlayOutSound()
    {
        objectAudio.PlayOneShot(OutSound, 1.0f);
    }
    //mainmenu:
    public void PlayStartSound()
    {
        objectAudio.PlayOneShot(StartSound, 1.0f);
    }
    public void PlayQuitSound()
    {
        objectAudio.PlayOneShot(QuitSound, 1.0f);
    }
}

//this script contains all the sound