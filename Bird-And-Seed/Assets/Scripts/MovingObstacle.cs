using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField, Tooltip("How fast the obstacle moves along the x-axis.")]
    private float moveSpeedX;

    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Assign random y pos and off-screen x pos
        transform.position = new Vector3(2f, Random.Range(-0.3f, 0f));

        // Set Rigidbody2D component and set linear velocity on the x-axis.
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.linearVelocityX = moveSpeedX;
    }
}
