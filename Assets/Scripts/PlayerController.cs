using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Speed of the vehicle
    private float horizontalInput; // Input for horizontal movement
    private float forwardInput; // Input for horizontal movement
    public float turnSpeed = 20f; // Speed of turning the vehicle

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input from the player
        forwardInput = Input.GetAxis("Vertical"); // Get vertical input from the player

        // Move the vehicle forward at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * turnSpeed);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime); // Rotate the vehicle based on horizontal input
    }
}
