using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField, Tooltip("How fast the obstacle moves along the x-axis.")]
    private float moveSpeedX;

    [SerializeField]
    private GameObject seed;

    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Randomly spawn a seed in the middle of the obstacle
        // Seed is included in the prefab by default, remove it if false
        // Random.value returns a float between 0.0 and 1.0
        if (Random.value < 0.5f && seed != null)
        {
            Destroy(seed);
        }

        // Set Rigidbody2D component and set linear velocity on the x-axis.
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.linearVelocityX = moveSpeedX;
    }
}
