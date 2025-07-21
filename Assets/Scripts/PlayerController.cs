using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Speed of the vehicle


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
