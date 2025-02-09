using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 20.0f;
    public float turnSpeed = 60.0f;
    public float horizontalInput = 0;
    public float verticalInput = 0;

    public string horizontalAxis = "Horizontal_P1";  // Default for Player 1
    public string verticalAxis = "Vertical_P1";

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis(horizontalAxis);
        verticalInput = Input.GetAxis(verticalAxis);

        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
