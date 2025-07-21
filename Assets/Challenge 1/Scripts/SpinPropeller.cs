using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of the propeller rotation
    public GameObject propeller; // Reference to the propeller GameObject

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
