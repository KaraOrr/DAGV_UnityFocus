using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20.0f;
    void Update()
    {
        //move laser forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
