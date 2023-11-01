using UnityEngine;

public class movingStar : MonoBehaviour
{
    public float speed = 20.0f;

    void Update()
    {
        //move Coin forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}


