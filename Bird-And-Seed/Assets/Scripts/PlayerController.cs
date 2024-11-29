using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Tooltip("How high the bird rises when it flaps.")]
    private float flapForce = 1.2f;
    [SerializeField, Tooltip("How fast the bird moves across the screen.")]
    private float moveSpeed = 1.0f;

    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set rigidbody component
        rb2d = GetComponent<Rigidbody2D>();

        // Set horizontal movement vector
        // TODO: Move to fixed update to slowly ramp up speed as time goes on
        rb2d.linearVelocityX = moveSpeed;
    }


    // Update is called once per frame. Used for checking inputs.
    private void Update()
    {
        Flap();
    }


    /// <summary>
    /// Checks for a flap input to apply a vertical force
    /// </summary>
    private void Flap()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.linearVelocityY = flapForce;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
